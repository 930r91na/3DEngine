using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PLAYGROUND
{
    public partial class MyForm : Form
    {
        List<Scene> _scenes;
        Scene _selectedScene;
        List<LightSource> _lights;
        Renderer _renderer;
        Canvas _canvas;
        Camera _camera;
        Filters _filters;


        private Model _selectedModel;
        private LightSource _selectedLight;

        private float _angle;
        TreeNode _selectedModelNode;
        TreeNode _selectLightNode;

        // Animation
        private int _longTrackbar = 0;
        readonly Bitmap _bmpTimeline;
        private Graphics _g;

        // Transformation variables
        private bool _isRotatingX;
        private bool _isRotatingY;
        private bool _isRotatingZ;

        // Filter variables
        private bool _isBrightnessActive = false;
        public static bool convolucion = false;

        public MyForm()
        {
            InitializeComponent();

            _scenes = new List<Scene>();
            _filters = new Filters();
            // Animatio
            _bmpTimeline = new Bitmap(PCT_TIMELINE.Width, PCT_TIMELINE.Height);
            _g = Graphics.FromImage(_bmpTimeline);
            PCT_TIMELINE.Image = _bmpTimeline;
            _longTrackbar = PCT_TIMELINE.Width;
        }

        private void Init()
        {
            _scenes = new List<Scene>();
            _canvas = new Canvas(PCT_CANVAS);
            _lights = new List<LightSource>();
            Matrix m = Matrix.Identity;
            _camera = new Camera(_canvas, new Transform(1, new Vertex(0,0,0,0), Matrix.Identity));

            _renderer = new Renderer(_canvas, _lights, _camera, _filters);
            if (_selectedScene == null)
            {
                _selectedScene = new Scene();
                _scenes.Add(_selectedScene);
            }

        }

        private void MyForm_SizeChanged(object sender, EventArgs e)
        {
            Init();
            
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            _renderer.RenderScene(_camera, _selectedScene, _isBrightnessActive);
            UpdateAutomaticRotation();
        }

        private void BTNOBJ_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Title = @"Buscar archivo";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;

                ReadObj(filePath);
            }
        }

        private void ReadObj(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                ReadObj(reader);
            }
        }


        public void ReadObjFromResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // Adjust namespace if your project's default namespace is different
            var fullResourceName = $"{assembly.GetName().Name}.{resourceName}";

            using (var stream = assembly.GetManifestResourceStream(fullResourceName))
            {
                if (stream == null)
                    throw new FileNotFoundException("Could not find the specified resource.", resourceName);

                if (stream == null) throw new ArgumentNullException(nameof(stream));

                using (var reader = new StreamReader(stream))
                {
                    ReadObj(reader);
                }
            }
        }


        private void ReadObj(StreamReader reader)
        {
            var vertexList = new List<Vertex>();
            var faceList = new List<Triangle>();

            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            reader.DiscardBufferedData();
            

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null && line.StartsWith("v "))
                {
                    var vertexValues = line.Split(' ');
                    var x = float.Parse(vertexValues[1]);
                    var y = float.Parse(vertexValues[2]);
                    var z = float.Parse(vertexValues[3]);
                    var vertex = new Vertex(x, y, z, 1);
                    vertexList.Add(vertex);
                }
                else if (line != null && line.StartsWith("f "))
                {
                    var faceValues = line.Split(' ');
                    var faceIndices = new List<int>();
                    for (var j = faceValues.Length - 1; j >= 0; j--)
                    {
                        var vertexIndexValues = faceValues[j].Split('/');
                        if (!int.TryParse(vertexIndexValues[0], out var vertexIndex)) continue;
                        vertexIndex--;
                        faceIndices.Add(vertexIndex);
                    }
                    
                    for (var i = 1; i < faceIndices.Count - 1; i++)
                    {
                        var random = new Random();
                        var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

                        var face = new Triangle(faceIndices[0], faceIndices[i], faceIndices[i + 1], color);
                        faceList.Add(face);
                    }
                }
            }

            var vertices = vertexList.ToArray();
            var faces = faceList.ToArray();

            NewModel(vertices, faces);
        }

        private void NewModel(Vertex[] vertices, Triangle[] triangles)
        {
            // Check number of models in the scene
            int index = _selectedScene.Models.Count + 1;
            var _mesh = new Mesh(vertices, triangles, index);
            var modelTransform = new Transform(1f, new Vertex(0, 0, 10, 1), Matrix.Identity);
            var newModel = new Model(new Vertex(0, 0, 0, 1), _mesh, modelTransform);

            _selectedModel = newModel;
            _selectedScene.AddModel(newModel);

            if (_selectedScene == null) return;

            treeView1.Nodes.Clear();

            // Add the model to the TreeView
            for (var i = 0; i < _selectedScene.Models.Count; i++)
            {
                var node = new TreeNode(@"Model " + (i + 1))
                {
                    Tag = _selectedScene.Models[i]
                };
                treeView1.Nodes.Add(node);
            }

            treeView1.SelectedNode = treeView1.Nodes[treeView1.Nodes.Count - 1];
            treeView1_AfterSelect(null, new TreeViewEventArgs(treeView1.SelectedNode));
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedModelNode = e.Node;
            _selectedModel = (Model)_selectedModelNode.Tag;

            // Update the radio buttons based on the selected model's mode
            switch (_selectedModel.Mode)
            {
                case Mode.Wireframe:
                    RDBTNWIREFRAME.Checked = true;
                    break;
                case Mode.Solid:
                    RDBTNSOLID.Checked = true;
                    break;
                case Mode.Shaded:
                    RDBTNSHADED.Checked = true;
                    break;
            }
        }

        private void RDBTNWIREFRAME_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedModel == null) return;

            _selectedModel.Mode = Mode.Wireframe;
        }

        private void RDBTNSOLID_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedModel == null) return;

            _selectedModel.Mode = Mode.Solid;
        }

        private void RDBTNSHADED_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedModel == null) return;

            _selectedModel.Mode = Mode.Shaded;
        }

        private void PCT_CANVAS_Click(object sender, EventArgs e)
        {
        }

        // Transformation movement
        private void UpdateAutomaticRotation()
        {
            // Model rotation
            if (_selectedModel == null) return;

            if (_isRotatingX)
            {
                _angle += 1f;
                _selectedModel.Transform.Rotation = Matrix.RotX(_angle);
            }

            if (_isRotatingY)
            {
                _angle += 1f;
                _selectedModel.Transform.Rotation = Matrix.RotY(_angle);
            }

            if (_isRotatingZ)
            {
                _angle += 1f;
                _selectedModel.Transform.Rotation = Matrix.RotZ(_angle);
            }
        }

        private void BTNRX_Click(object sender, EventArgs e)
        {
            _isRotatingX = !_isRotatingX;
            if (!_isRotatingX)
            {
                BTNRX.BackColor = Color.Coral;
                BTNRX.ForeColor = Color.White;
            }
            else
            {
                BTNRX.BackColor = Color.White;
                BTNRX.ForeColor = Color.Black;
            }
        }

        private void BTNRY_Click(object sender, EventArgs e)
        {
            _isRotatingY = !_isRotatingY;
            if (!_isRotatingY)
            {
                BTNRY.BackColor = Color.Coral;
                BTNRY.ForeColor = Color.White;
            }
            else
            {
                BTNRY.BackColor = Color.White;
                BTNRY.ForeColor = Color.Black;
            }
        }

        private void BTNRZ_Click(object sender, EventArgs e)
        {
            _isRotatingZ = !_isRotatingZ;
            if (!_isRotatingZ)
            {
                BTNRZ.BackColor = Color.Coral;
                BTNRZ.ForeColor = Color.White;
            }
            else
            {
                BTNRZ.BackColor = Color.White;
                BTNRZ.ForeColor = Color.Black;
            }
        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Light source operations
            if (_selectedLight != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.J:
                        _selectedLight.Position.X -= 5f;
                        break;
                    case Keys.L:
                        _selectedLight.Position.X += 5f;
                        break;
                    case Keys.I:
                        _selectedLight.Position.Y += 5f;
                        break;
                    case Keys.K:
                        _selectedLight.Position.Y -= 5f;
                        break;
                    case Keys.U:
                        _selectedLight.Position.Z += 10f;
                        break;
                    case Keys.O:
                        _selectedLight.Position.Z -= 10f;
                        break;
                    case Keys.H:
                        RemoveLightSource(_selectedLight);
                        break;
                }
            }

            // Models operations
            if (_selectedModel != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        _selectedModel.Transform.Translation.X -= 0.5f;
                        break;
                    case Keys.D:
                        _selectedModel.Transform.Translation.X += 0.5f;
                        break;
                    case Keys.W:
                        _selectedModel.Transform.Translation.Y += 0.5f;
                        break;
                    case Keys.S:
                        _selectedModel.Transform.Translation.Y -= 0.5f;
                        break;
                    case Keys.Z:
                        _selectedModel.Transform.Translation.Z += 0.5f;
                        break;
                    case Keys.X:
                        _selectedModel.Transform.Translation.Z -= 0.5f;
                        break;
                    case Keys.Q:
                        _selectedModel.Transform.Scale += 0.1f;
                        break;
                    case Keys.E:
                        _selectedModel.Transform.Scale -= 0.1f;
                        break;
                    case Keys.F:
                        RemoveModel(_selectedModel);
                        break;
                }
            }
        }

        private void RemoveModel(Model model)
        {
            if (model == null) return;
            _selectedScene.RemoveModel(model);
            treeView1.Nodes.Remove(_selectedModelNode);
            if (treeView1.Nodes.Count > 0)
            {
                treeView1.SelectedNode = treeView1.Nodes[treeView1.Nodes.Count - 1];
            }
            else
            {
                _selectedModel = null;
            }
        }

        private void BTNCUBE_Click(object sender, EventArgs e)
        {
            ReadObjFromResource("Resources.Square.obj");
        }

        private void BTNSPHERE_Click(object sender, EventArgs e)
        {
            ReadObjFromResource("Resources.sph.obj");
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            // Create a new model with a triangle 
            Vertex[] vertices =
            [
                new Vertex(0, 1, 0, 1),
                new Vertex(1, 0, 0, 0.5f),
                new Vertex(0, 0, 1, 0.3f),
            ];

            Triangle[] faces =
            [
                new Triangle(0, 1, 2, Color.Red),
            ];

            NewModel(vertices, faces);
        }

        // Light source management
        private void NewLightSource(Vertex position, float intensity)
        {
            _lights.Add(new LightSource(position, intensity, _canvas));

            _selectedLight = _lights[_lights.Count - 1];

            TVLIGHTS.Nodes.Clear();

            for (var i = 0; i < _lights.Count; i++)
            {
                var node = new TreeNode(@"Light " + (i + 1) )
                {
                    Tag = _lights[i]
                };
                TVLIGHTS.Nodes.Add(node);
            }
        }

        private void RemoveLightSource(LightSource light)
        {
            if (light == null) return;
            _lights.Remove(light);
            TVLIGHTS.Nodes.Remove(_selectLightNode);
            if (TVLIGHTS.Nodes.Count > 0)
            {
                TVLIGHTS.SelectedNode = TVLIGHTS.Nodes[TVLIGHTS.Nodes.Count - 1];
            }
        }

        private void BTNLIGHT_Click(object sender, EventArgs e)
        {
            // Get the intensity from the text box
            if (!float.TryParse(TBINTENSITY.Text, out var intensity))
            {
                MessageBox.Show(@"Please enter a valid intensity value.");
                return;
            }

            NewLightSource(new Vertex(0, 0, 0, 1), intensity);
        }

        private void TVLIGHTS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectLightNode = e.Node;
            _selectedLight = (LightSource)_selectLightNode.Tag;
            TBINTENSITY.Text = _selectedLight.Intensity.ToString();

            switch (_selectedLight.Type)
            {
                case LightSource.LightType.Point:
                    RDBTNPOINT.Checked = true;
                    break;
                case LightSource.LightType.Ambient:
                    RDBTNAMBIENT.Checked = true;
                    break;
            }
        }

        private void TBINTENSITY_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void RDBTNAMBIENT_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedLight == null) return;
            _selectedLight.Type = LightSource.LightType.Ambient;
        }

        private void RDBTNPOINT_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedLight == null) return;
            _selectedLight.Type = LightSource.LightType.Point;
        }

        private void BTN_ADDKEY_Click(object sender, EventArgs e)
        {
            // Draw the keyframe
            int span = (_longTrackbar - 16) / 30;
            int timelineValue = TRK_MOVIE.Value * span;
            _canvas.DrawKeyframe(new PointF(timelineValue + 8, 0), Color.IndianRed, _bmpTimeline);
            PCT_TIMELINE.Invalidate();

            if (_selectedScene == null) return;

            int currentTime = TRK_MOVIE.Value;
            foreach (var model in _selectedScene.Models)
            {
                Keyframe keyframe = new Keyframe(
                    model.GetPosition().Clone(),
                    new Transform(
                        model.GetTransform().Scale,
                        model.GetTransform().Translation.Clone(),
                        model.GetTransform().Rotation.Clone()),  
                    currentTime
                );

                model.AddKeyFrame(keyframe);
            }

        }
        private void BTN_PLAY_Click(object sender, EventArgs e)
        {
            int duration = 6500; // 3 seconds
            int interval = duration / 80;
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            int currentTime = 0;

            timer.Tick += (o, args) =>
            {
                // Interpolate for each Model
                for (var i = 0; i < _selectedScene.Models.Count; i++)
                {
                    _selectedScene.Models[i].Interpolate(currentTime);
                }

                TRK_MOVIE.Value = currentTime;
                ApplyTransformationAndRender();

                if (currentTime >= TRK_MOVIE.Maximum)
                {
                    timer.Stop();
                    timer.Dispose();
                }
                else
                {
                    currentTime++;
                }
            };

            timer.Start();

        }

        private void ApplyTransformationAndRender()
        {
            for (var i = 0; i < _selectedScene.Models.Count; i++)
            {
                _renderer.RenderScene(_camera, _selectedScene, _isBrightnessActive);
            }
        }

        private void TRK_MOVIE_Scroll(object sender, EventArgs e)
        {

        }

        private void PCT_TIMELINE_Click(object sender, EventArgs e)
        {

        }

        private void LBLCAMARA_Click(object sender, EventArgs e)
        {

        }

        private void BTNBLUR_Click(object sender, EventArgs e)
        {
            if (!convolucion)
            {
                Bitmap bitmap = new Bitmap(_canvas.bmp);
                PCT_CANVAS.Image = Renderer.Convolucion(bitmap, _canvas.Width, _canvas.Height);
                Invalidate();
                //TIMER.Stop();
                convolucion = true;
            }
            else
            {
                PCT_CANVAS.Image = _canvas.bmp;
                convolucion = false;
                //TIMER.Start();
            }
        }

        private void BTNGRYS_Click(object sender, EventArgs e)
        {
            _filters.Grayscale = !_filters.Grayscale;

            if (!_filters.Grayscale)
            {
                BTNGRYS.BackColor = Color.DeepPink;
                BTNGRYS.ForeColor = Color.White;
            }
            else
            {
                BTNGRYS.BackColor = Color.White;
                BTNGRYS.ForeColor = Color.Black;
            }
        }

        private void BTNBW_Click(object sender, EventArgs e)
        {
            _filters.BlackAndWhite = !_filters.BlackAndWhite;

            if (!_filters.BlackAndWhite)
            {
                BTNBW.BackColor = Color.DeepPink;
                BTNBW.ForeColor = Color.White;
            }
            else
            {
                BTNBW.BackColor = Color.White;
                BTNBW.ForeColor = Color.Black;
            }
        }

        private void BTNINVERSE_Click(object sender, EventArgs e)
        {
            _filters.Invert = !_filters.Invert;

            if (!_filters.Invert)
            {
                BTNINVERSE.BackColor = Color.DeepPink;
                BTNINVERSE.ForeColor = Color.White;
            }
            else
            {
                BTNINVERSE.BackColor = Color.White;
                BTNINVERSE.ForeColor = Color.Black;
            }
        }

        private void BTNSEPIA_Click(object sender, EventArgs e)
        {
            _filters.Sepia = !_filters.Sepia;

            if (!_filters.Sepia)
            {
                BTNSEPIA.BackColor = Color.DeepPink;
                BTNSEPIA.ForeColor = Color.White;
            }
            else
            {
                BTNSEPIA.BackColor = Color.White;
                BTNSEPIA.ForeColor = Color.Black;
            }
        }

        private void BTNBRIGHTNESS_Click(object sender, EventArgs e)
        {
            // Increase the brightness clamping to 255
            _filters.Brightness = Math.Min(255, _filters.Brightness + 20);


            if (_filters.Brightness != 0)
            {
                BTNBRIGHTNESS.BackColor = Color.DeepPink;
                BTNBRIGHTNESS.ForeColor = Color.White;
                //_isBrightnessActive = true;
            }
            else
            {
                _filters.Brightness -= 20;
                BTNBRIGHTNESS.BackColor = Color.White;
                BTNBRIGHTNESS.ForeColor = Color.Black;
                //_isBrightnessActive = false;
            }

        }

        private void BTNTW_Click(object sender, EventArgs e)
        {
            _filters.Twilight = !_filters.Twilight;
        }

        private void BTNDLFILTRS_Click(object sender, EventArgs e)
        {
            _filters.Reset = !_filters.Reset;
        }

        private void BTNDLKF_Click(object sender, EventArgs e)
        {
            // Delete all keyframes
            foreach (var model in _selectedScene.Models)
            {
                model.ClearKeyframes();
            }
            _g.Clear(Color.FromArgb(20, 20, 20));
            PCT_TIMELINE.Invalidate();
            // Delete the keyframes from the timeline
            
        }
    }
}