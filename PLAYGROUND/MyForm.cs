using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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


        private Model _selectedModel;
        private LightSource _selectedLight;

        private float _angle;
        TreeNode _selectedModelNode;
        TreeNode _selectLightNode;

        // Transformation variables
        private bool _isRotatingX;
        private bool _isRotatingY;
        private bool _isRotatingZ;
        private bool _isRotatingCameraX;
        private bool _isRotatingCameraY;
        private bool _isRotatingCameraZ;

        public MyForm()
        {
            _scenes = new List<Scene>();
            InitializeComponent();
        }

        private void Init()
        {
            _canvas = new Canvas(PCT_CANVAS);
            _lights = new List<LightSource>();
            Matrix m = Matrix.Identity;
            _camera = new Camera(_canvas, new Transform(1, new Vertex(0,0,0,0), Matrix.Identity));

            _renderer = new Renderer(_canvas, _lights, _camera);
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
            _renderer.RenderScene(_camera, _selectedScene);
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
            var _mesh = new Mesh(vertices, triangles);
            var modelTransform = new Transform(1f, new Vertex(0, 0, 10, 1), Matrix.Identity);
            var newModel = new Model(new Vertex(0, 0, 0, 1), _mesh, modelTransform);

            _selectedModel = newModel;
            _selectedScene.AddModel(newModel);

            if (_selectedScene == null) return;

            treeView1.Nodes.Clear();

            // Add the model to the TreeView
            for (var i = 0; i < _selectedScene.Models.Count; i++)
            {
                var node = new TreeNode(@"Model " + (i + 1) + "(" + _selectedScene.Models[i].Position.X + "," + _selectedScene.Models[i].Position.Y + "," + _selectedScene.Models[i].Position.Z+ ")")
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

            // Camera rotation
            if (_camera == null) return;

            if (_isRotatingCameraX)
            {
                _camera.Transform.Rotation = Matrix.RotX(0.1f);
            }
            if (_isRotatingCameraY)
            {
                _camera.Transform.Rotation = Matrix.RotY(0.1f);
            }
            if (_isRotatingCameraZ)
            {
                _camera.Transform.Rotation = Matrix.RotZ(0.1f);
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
            if (_selectedModel == null) return;
            // Models operations
            switch (e.KeyCode)
            {
                case Keys.A:
                    _selectedModel.Transform.Translation.X -= 0.1f;
                    break;
                case Keys.D:
                    _selectedModel.Transform.Translation.X += 0.1f;
                    break;
                case Keys.W:
                    _selectedModel.Transform.Translation.Y += 0.1f;
                    break;
                case Keys.S:
                    _selectedModel.Transform.Translation.Y -= 0.1f;
                    break;
                case Keys.Z:
                    _selectedModel.Transform.Translation.Z += 0.1f;
                    break;
                case Keys.X:
                    _selectedModel.Transform.Translation.Z -= 0.1f;
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
            if (_selectedLight == null) return;
            // Light source operations
            switch (e.KeyCode)
            {
                case Keys.J:
                    _selectedLight.Position.X -= 1f;
                    break;
                case Keys.L:
                    _selectedLight.Position.X += 1f;
                    break;
                case Keys.I:
                    _selectedLight.Position.Y += 1f;
                    break;
                case Keys.K:
                    _selectedLight.Position.Y -= 1f;
                    break;
                case Keys.U:
                    _selectedLight.Position.Z += 1f;
                    break;
                case Keys.O:
                    _selectedLight.Position.Z -= 1f;
                    break;
                case Keys.H:
                    RemoveLightSource(_selectedLight);
                    break;
            }
            // Camera operations
            if (_camera == null) return;
            switch (e.KeyCode)
            {
                case Keys.T:
                    _camera.Position.X -= 1f;
                    break;
                case Keys.U:
                    _camera.Position.X += 1f;
                    break;
                case Keys.Y:
                    _camera.Position.Y += 1f;
                    break;
                case Keys.G:
                    _camera.Position.Y -= 1f;
                    break;
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
            _lights.Add(new LightSource(position, intensity));
            _selectedLight = _lights[_lights.Count - 1];
            // Update the tree view
            for (var i = 0; i < _lights.Count; i++)
            {
                var node = new TreeNode(@"Light " + (i + 1) + "(" + _lights[i].Position.X + "," + _lights[i].Position.Y + "," + _lights[i].Position.Z +")")
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

            NewLightSource(new Vertex(10, 10, 10, 1), intensity);
        }

        private void TVLIGHTS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectLightNode = e.Node;
            _selectedLight = (LightSource)_selectLightNode.Tag;
            TBINTENSITY.Text = _selectedLight.Intensity.ToString();

            switch (_selectedLight.Type)
            {
                case LightSource.LightType.PointNotSmooth:
                    RDBTNDIRECTION.Checked = true;
                    break;
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

        private void CRX_Click(object sender, EventArgs e)
        {
            _isRotatingCameraX = !_isRotatingCameraX;
            if (!_isRotatingCameraX)
            {
                BTNCRX.BackColor = Color.Peru;
                BTNCRX.ForeColor = Color.White;
            }
            else
            {
                BTNCRX.BackColor = Color.White;
                BTNCRX.ForeColor = Color.Black;
            }
        }

        private void BTNCRY_Click(object sender, EventArgs e)
        {
            _isRotatingCameraY = !_isRotatingCameraY;
            if (!_isRotatingCameraY)
            {
                BTNCRY.BackColor = Color.Peru;
                BTNCRY.ForeColor = Color.White;
            }
            else
            {
                BTNCRY.BackColor = Color.White;
                BTNCRY.ForeColor = Color.Black;
            }
        }

        private void BTNCRZ_Click(object sender, EventArgs e)
        {
            _isRotatingCameraZ = !_isRotatingCameraZ;
            if(!_isRotatingCameraZ){
                BTNCRZ.BackColor = Color.Peru;
                BTNCRZ.ForeColor = Color.White;
            }
            else
            {
                BTNCRZ.BackColor = Color.White;
                BTNCRZ.ForeColor = Color.Black;
            }
        }

        private void RDBTNAMBIENT_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedLight == null) return;
            _selectedLight.Type = LightSource.LightType.Ambient;
        }

        private void RDBTNDIRECTION_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedLight == null) return;
            _selectedLight.Type = LightSource.LightType.PointNotSmooth;
        }

        private void RDBTNPOINT_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedLight == null) return;
            _selectedLight.Type = LightSource.LightType.Point;
        }
    }
}