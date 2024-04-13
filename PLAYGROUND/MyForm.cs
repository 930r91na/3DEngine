using System;
using System.Windows.Forms;

namespace PLAYGROUND
{
    public partial class MyForm : Form
    {
        Scene scene;
        Renderer renderer;
        Canvas canvas;

        public MyForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            canvas = new Canvas(PCT_CANVAS);
            renderer = new Renderer(canvas);
            scene = new Scene();
        }

        private void MyForm_SizeChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            renderer.RenderScene(scene);

        }

        private void BTNOBJ_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void PCT_CANVAS_Click(object sender, EventArgs e)
        {

        }

        // Transformation movement
        private void BTNRX_Click(object sender, EventArgs e)
        {

        }

        private void BTNRY_Click(object sender, EventArgs e)
        {

        }

        private void BTNRZ_Click(object sender, EventArgs e)
        {

        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    // Move forward
                    break;
                case Keys.Down:
                    // Move backward
                    break;
                case Keys.Q:
                    // Increase size
                    break;
                case Keys.W:
                    // Decrease size
                    break;
            }
        }

    }
}
