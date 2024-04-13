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
        Renderer _renderer;
        Canvas _canvas;

        private Model _selectedModel;

        private float _angle;
        TreeNode _selectedNode;

        // Transformation variables
        private bool _isRotatingX;
        private bool _isRotatingY;
        private bool _isRotatingZ;

        // Render Mode
        bool _isWireframe;
        bool _isSolid;
        bool _isShaded;

        public MyForm()
        {
            _scenes = new List<Scene>();
            InitializeComponent();
        }

        private void Init()
        {
            _canvas = new Canvas(PCT_CANVAS);

            _renderer = new Renderer(_canvas);
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
            _renderer.RenderScene(_selectedScene);
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
                        var face = new Triangle(faceIndices[0], faceIndices[i], faceIndices[i + 1], Color.White);
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

            for (var i = 0; i < _selectedScene.Models.Count; i++)
            {
                var node = new TreeNode(@"Model " + (i + 1))
                {
                    Tag = _selectedScene.Models[i]
                };
                treeView1.Nodes.Add(node);
            }

            // TODO: Check if remove this line
            _renderer.RenderScene(_selectedScene);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedNode = e.Node;
            _selectedModel = (Model)_selectedNode.Tag;
        }

        private void RDBTNWIREFRAME_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedModel == null) return;

            _selectedModel.Mode = Mode.Wireframe;
        }

        private void RDBTNSOLID_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedNode == null) return;

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
        }

        private void RemoveModel(Model model)
        {
            if (model == null) return;
            _selectedScene.RemoveModel(model);
            treeView1.Nodes.Remove(_selectedNode);
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
    }
}