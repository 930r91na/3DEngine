using System.Drawing;

namespace PLAYGROUND
{
    partial class MyForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PNL_MAIN = new System.Windows.Forms.Panel();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBINTENSITY = new System.Windows.Forms.TextBox();
            this.BTNLIGHT = new System.Windows.Forms.Button();
            this.LBLLIGHT = new System.Windows.Forms.Label();
            this.TVLIGHTS = new System.Windows.Forms.TreeView();
            this.LBLTYPE = new System.Windows.Forms.Label();
            this.RDBTNAMBIENT = new System.Windows.Forms.RadioButton();
            this.RDBTNDIRECTION = new System.Windows.Forms.RadioButton();
            this.RDBTNPOINT = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNOBJ = new System.Windows.Forms.Button();
            this.BTNCUBE = new System.Windows.Forms.Button();
            this.BTNSPHERE = new System.Windows.Forms.Button();
            this.LBLTREEVIEW = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.LBLRENDERMODE = new System.Windows.Forms.Label();
            this.RDBTNWIREFRAME = new System.Windows.Forms.RadioButton();
            this.RDBTNSOLID = new System.Windows.Forms.RadioButton();
            this.RDBTNSHADED = new System.Windows.Forms.RadioButton();
            this.PNL_BOTTOM = new System.Windows.Forms.Panel();
            this.PCT_TIMELINE = new System.Windows.Forms.PictureBox();
            this.TRK_MOVIE = new System.Windows.Forms.TrackBar();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLCAMARA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FLWLYTBTNSMOVE = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNRX = new System.Windows.Forms.Button();
            this.BTNRY = new System.Windows.Forms.Button();
            this.BTNRZ = new System.Windows.Forms.Button();
            this.PanelAnimation = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_ADDKEY = new System.Windows.Forms.Button();
            this.BTN_PLAY = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNCRX = new System.Windows.Forms.Button();
            this.BTNCRY = new System.Windows.Forms.Button();
            this.BTNCRZ = new System.Windows.Forms.Button();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.PNL_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PNL_BOTTOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_TIMELINE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_MOVIE)).BeginInit();
            this.PNL_HEADER.SuspendLayout();
            this.FLWLYTBTNSMOVE.SuspendLayout();
            this.PanelAnimation.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_MAIN
            // 
            this.PNL_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PNL_MAIN.Controls.Add(this.PCT_CANVAS);
            this.PNL_MAIN.Controls.Add(this.panel2);
            this.PNL_MAIN.Controls.Add(this.panel1);
            this.PNL_MAIN.Controls.Add(this.PNL_BOTTOM);
            this.PNL_MAIN.Controls.Add(this.LBL_STATUS);
            this.PNL_MAIN.Controls.Add(this.PNL_HEADER);
            this.PNL_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_MAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNL_MAIN.ForeColor = System.Drawing.Color.Silver;
            this.PNL_MAIN.Location = new System.Drawing.Point(0, 0);
            this.PNL_MAIN.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PNL_MAIN.Name = "PNL_MAIN";
            this.PNL_MAIN.Size = new System.Drawing.Size(3281, 1700);
            this.PNL_MAIN.TabIndex = 0;
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PCT_CANVAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCT_CANVAS.Location = new System.Drawing.Point(467, 223);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PCT_CANVAS.MinimumSize = new System.Drawing.Size(175, 91);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(2413, 1196);
            this.PCT_CANVAS.TabIndex = 6;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.Click += new System.EventHandler(this.PCT_CANVAS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(2880, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 1196);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.TBINTENSITY);
            this.flowLayoutPanel2.Controls.Add(this.BTNLIGHT);
            this.flowLayoutPanel2.Controls.Add(this.LBLLIGHT);
            this.flowLayoutPanel2.Controls.Add(this.TVLIGHTS);
            this.flowLayoutPanel2.Controls.Add(this.LBLTYPE);
            this.flowLayoutPanel2.Controls.Add(this.RDBTNAMBIENT);
            this.flowLayoutPanel2.Controls.Add(this.RDBTNDIRECTION);
            this.flowLayoutPanel2.Controls.Add(this.RDBTNPOINT);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 31);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(376, 1013);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Intensity:";
            // 
            // TBINTENSITY
            // 
            this.TBINTENSITY.Location = new System.Drawing.Point(211, 4);
            this.TBINTENSITY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBINTENSITY.Name = "TBINTENSITY";
            this.TBINTENSITY.Size = new System.Drawing.Size(114, 56);
            this.TBINTENSITY.TabIndex = 4;
            this.TBINTENSITY.Text = "0.1";
            this.TBINTENSITY.TextChanged += new System.EventHandler(this.TBINTENSITY_TextChanged);
            // 
            // BTNLIGHT
            // 
            this.BTNLIGHT.BackColor = System.Drawing.Color.Navy;
            this.BTNLIGHT.Location = new System.Drawing.Point(5, 68);
            this.BTNLIGHT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNLIGHT.Name = "BTNLIGHT";
            this.BTNLIGHT.Size = new System.Drawing.Size(362, 94);
            this.BTNLIGHT.TabIndex = 2;
            this.BTNLIGHT.Text = "Add Light";
            this.BTNLIGHT.UseVisualStyleBackColor = false;
            this.BTNLIGHT.Click += new System.EventHandler(this.BTNLIGHT_Click);
            // 
            // LBLLIGHT
            // 
            this.LBLLIGHT.AutoSize = true;
            this.LBLLIGHT.Location = new System.Drawing.Point(5, 166);
            this.LBLLIGHT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLLIGHT.Name = "LBLLIGHT";
            this.LBLLIGHT.Size = new System.Drawing.Size(150, 51);
            this.LBLLIGHT.TabIndex = 1;
            this.LBLLIGHT.Text = "Lights:";
            // 
            // TVLIGHTS
            // 
            this.TVLIGHTS.BackColor = System.Drawing.Color.Black;
            this.TVLIGHTS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TVLIGHTS.Location = new System.Drawing.Point(5, 221);
            this.TVLIGHTS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TVLIGHTS.Name = "TVLIGHTS";
            this.TVLIGHTS.Size = new System.Drawing.Size(359, 504);
            this.TVLIGHTS.TabIndex = 0;
            this.TVLIGHTS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVLIGHTS_AfterSelect);
            // 
            // LBLTYPE
            // 
            this.LBLTYPE.AutoSize = true;
            this.LBLTYPE.Location = new System.Drawing.Point(5, 729);
            this.LBLTYPE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLTYPE.Name = "LBLTYPE";
            this.LBLTYPE.Size = new System.Drawing.Size(251, 51);
            this.LBLTYPE.TabIndex = 5;
            this.LBLTYPE.Text = "Type:           ";
            // 
            // RDBTNAMBIENT
            // 
            this.RDBTNAMBIENT.AutoSize = true;
            this.RDBTNAMBIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBTNAMBIENT.Location = new System.Drawing.Point(5, 784);
            this.RDBTNAMBIENT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RDBTNAMBIENT.Name = "RDBTNAMBIENT";
            this.RDBTNAMBIENT.Size = new System.Drawing.Size(205, 52);
            this.RDBTNAMBIENT.TabIndex = 6;
            this.RDBTNAMBIENT.TabStop = true;
            this.RDBTNAMBIENT.Text = "Ambient";
            this.RDBTNAMBIENT.UseVisualStyleBackColor = true;
            this.RDBTNAMBIENT.CheckedChanged += new System.EventHandler(this.RDBTNAMBIENT_CheckedChanged);
            // 
            // RDBTNDIRECTION
            // 
            this.RDBTNDIRECTION.AutoSize = true;
            this.RDBTNDIRECTION.Location = new System.Drawing.Point(5, 844);
            this.RDBTNDIRECTION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RDBTNDIRECTION.Name = "RDBTNDIRECTION";
            this.RDBTNDIRECTION.Size = new System.Drawing.Size(390, 55);
            this.RDBTNDIRECTION.TabIndex = 8;
            this.RDBTNDIRECTION.TabStop = true;
            this.RDBTNDIRECTION.Text = "Point Not Smooth";
            this.RDBTNDIRECTION.UseVisualStyleBackColor = true;
            this.RDBTNDIRECTION.CheckedChanged += new System.EventHandler(this.RDBTNDIRECTION_CheckedChanged);
            // 
            // RDBTNPOINT
            // 
            this.RDBTNPOINT.AutoSize = true;
            this.RDBTNPOINT.Location = new System.Drawing.Point(5, 907);
            this.RDBTNPOINT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RDBTNPOINT.Name = "RDBTNPOINT";
            this.RDBTNPOINT.Size = new System.Drawing.Size(152, 55);
            this.RDBTNPOINT.TabIndex = 7;
            this.RDBTNPOINT.TabStop = true;
            this.RDBTNPOINT.Text = "Point";
            this.RDBTNPOINT.UseVisualStyleBackColor = true;
            this.RDBTNPOINT.CheckedChanged += new System.EventHandler(this.RDBTNPOINT_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 1196);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BTNOBJ);
            this.flowLayoutPanel1.Controls.Add(this.BTNCUBE);
            this.flowLayoutPanel1.Controls.Add(this.BTNSPHERE);
            this.flowLayoutPanel1.Controls.Add(this.LBLTREEVIEW);
            this.flowLayoutPanel1.Controls.Add(this.treeView1);
            this.flowLayoutPanel1.Controls.Add(this.LBLRENDERMODE);
            this.flowLayoutPanel1.Controls.Add(this.RDBTNWIREFRAME);
            this.flowLayoutPanel1.Controls.Add(this.RDBTNSOLID);
            this.flowLayoutPanel1.Controls.Add(this.RDBTNSHADED);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 1013);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BTNOBJ
            // 
            this.BTNOBJ.BackColor = System.Drawing.Color.DarkRed;
            this.BTNOBJ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNOBJ.Location = new System.Drawing.Point(5, 4);
            this.BTNOBJ.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNOBJ.Name = "BTNOBJ";
            this.BTNOBJ.Size = new System.Drawing.Size(390, 78);
            this.BTNOBJ.TabIndex = 0;
            this.BTNOBJ.Text = "UPLOAD OBJ";
            this.BTNOBJ.UseVisualStyleBackColor = false;
            this.BTNOBJ.Click += new System.EventHandler(this.BTNOBJ_Click);
            // 
            // BTNCUBE
            // 
            this.BTNCUBE.BackColor = System.Drawing.Color.DarkRed;
            this.BTNCUBE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNCUBE.Location = new System.Drawing.Point(5, 90);
            this.BTNCUBE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCUBE.Name = "BTNCUBE";
            this.BTNCUBE.Size = new System.Drawing.Size(201, 78);
            this.BTNCUBE.TabIndex = 1;
            this.BTNCUBE.Text = "Cube";
            this.BTNCUBE.UseVisualStyleBackColor = false;
            this.BTNCUBE.Click += new System.EventHandler(this.BTNCUBE_Click);
            // 
            // BTNSPHERE
            // 
            this.BTNSPHERE.BackColor = System.Drawing.Color.DarkRed;
            this.BTNSPHERE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNSPHERE.Location = new System.Drawing.Point(216, 90);
            this.BTNSPHERE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNSPHERE.Name = "BTNSPHERE";
            this.BTNSPHERE.Size = new System.Drawing.Size(180, 78);
            this.BTNSPHERE.TabIndex = 2;
            this.BTNSPHERE.Text = "Sphere";
            this.BTNSPHERE.UseVisualStyleBackColor = false;
            this.BTNSPHERE.Click += new System.EventHandler(this.BTNSPHERE_Click);
            // 
            // LBLTREEVIEW
            // 
            this.LBLTREEVIEW.AutoSize = true;
            this.LBLTREEVIEW.Location = new System.Drawing.Point(5, 172);
            this.LBLTREEVIEW.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLTREEVIEW.Name = "LBLTREEVIEW";
            this.LBLTREEVIEW.Size = new System.Drawing.Size(185, 51);
            this.LBLTREEVIEW.TabIndex = 6;
            this.LBLTREEVIEW.Text = "Models: ";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(5, 227);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(387, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // LBLRENDERMODE
            // 
            this.LBLRENDERMODE.AutoSize = true;
            this.LBLRENDERMODE.Location = new System.Drawing.Point(5, 657);
            this.LBLRENDERMODE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLRENDERMODE.Name = "LBLRENDERMODE";
            this.LBLRENDERMODE.Size = new System.Drawing.Size(294, 51);
            this.LBLRENDERMODE.TabIndex = 7;
            this.LBLRENDERMODE.Text = "Render Mode:";
            // 
            // RDBTNWIREFRAME
            // 
            this.RDBTNWIREFRAME.AutoSize = true;
            this.RDBTNWIREFRAME.Location = new System.Drawing.Point(5, 712);
            this.RDBTNWIREFRAME.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RDBTNWIREFRAME.Name = "RDBTNWIREFRAME";
            this.RDBTNWIREFRAME.Size = new System.Drawing.Size(252, 55);
            this.RDBTNWIREFRAME.TabIndex = 3;
            this.RDBTNWIREFRAME.TabStop = true;
            this.RDBTNWIREFRAME.Text = "Wireframe";
            this.RDBTNWIREFRAME.UseVisualStyleBackColor = true;
            this.RDBTNWIREFRAME.CheckedChanged += new System.EventHandler(this.RDBTNWIREFRAME_CheckedChanged);
            // 
            // RDBTNSOLID
            // 
            this.RDBTNSOLID.AutoSize = true;
            this.RDBTNSOLID.Location = new System.Drawing.Point(5, 775);
            this.RDBTNSOLID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RDBTNSOLID.Name = "RDBTNSOLID";
            this.RDBTNSOLID.Size = new System.Drawing.Size(183, 55);
            this.RDBTNSOLID.TabIndex = 4;
            this.RDBTNSOLID.TabStop = true;
            this.RDBTNSOLID.Text = "Solid   ";
            this.RDBTNSOLID.UseVisualStyleBackColor = true;
            this.RDBTNSOLID.CheckedChanged += new System.EventHandler(this.RDBTNSOLID_CheckedChanged);
            // 
            // RDBTNSHADED
            // 
            this.RDBTNSHADED.AutoSize = true;
            this.RDBTNSHADED.Location = new System.Drawing.Point(5, 838);
            this.RDBTNSHADED.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RDBTNSHADED.Name = "RDBTNSHADED";
            this.RDBTNSHADED.Size = new System.Drawing.Size(202, 55);
            this.RDBTNSHADED.TabIndex = 5;
            this.RDBTNSHADED.TabStop = true;
            this.RDBTNSHADED.Text = "Shaded";
            this.RDBTNSHADED.UseVisualStyleBackColor = true;
            this.RDBTNSHADED.CheckedChanged += new System.EventHandler(this.RDBTNSHADED_CheckedChanged);
            // 
            // PNL_BOTTOM
            // 
            this.PNL_BOTTOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_BOTTOM.Controls.Add(this.PCT_TIMELINE);
            this.PNL_BOTTOM.Controls.Add(this.TRK_MOVIE);
            this.PNL_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 1419);
            this.PNL_BOTTOM.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(3281, 230);
            this.PNL_BOTTOM.TabIndex = 3;
            // 
            // PCT_TIMELINE
            // 
            this.PCT_TIMELINE.Location = new System.Drawing.Point(651, 91);
            this.PCT_TIMELINE.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PCT_TIMELINE.Name = "PCT_TIMELINE";
            this.PCT_TIMELINE.Size = new System.Drawing.Size(2018, 94);
            this.PCT_TIMELINE.TabIndex = 1;
            this.PCT_TIMELINE.TabStop = false;
            this.PCT_TIMELINE.Click += new System.EventHandler(this.PCT_TIMELINE_Click);
            // 
            // TRK_MOVIE
            // 
            this.TRK_MOVIE.Location = new System.Drawing.Point(651, 33);
            this.TRK_MOVIE.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.TRK_MOVIE.Maximum = 30;
            this.TRK_MOVIE.Name = "TRK_MOVIE";
            this.TRK_MOVIE.Size = new System.Drawing.Size(2018, 101);
            this.TRK_MOVIE.TabIndex = 0;
            this.TRK_MOVIE.Scroll += new System.EventHandler(this.TRK_MOVIE_Scroll);
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_STATUS.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.Location = new System.Drawing.Point(0, 1649);
            this.LBL_STATUS.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(3281, 51);
            this.LBL_STATUS.TabIndex = 2;
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_HEADER.Controls.Add(this.BTNCRX);
            this.PNL_HEADER.Controls.Add(this.label3);
            this.PNL_HEADER.Controls.Add(this.LBLCAMARA);
            this.PNL_HEADER.Controls.Add(this.label2);
            this.PNL_HEADER.Controls.Add(this.FLWLYTBTNSMOVE);
            this.PNL_HEADER.Controls.Add(this.PanelAnimation);
            this.PNL_HEADER.Controls.Add(this.flowLayoutPanel3);
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(3281, 223);
            this.PNL_HEADER.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1386, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Animation:";
            // 
            // LBLCAMARA
            // 
            this.LBLCAMARA.AutoSize = true;
            this.LBLCAMARA.Location = new System.Drawing.Point(2069, 36);
            this.LBLCAMARA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLCAMARA.Name = "LBLCAMARA";
            this.LBLCAMARA.Size = new System.Drawing.Size(118, 51);
            this.LBLCAMARA.TabIndex = 7;
            this.LBLCAMARA.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model: ";
            // 
            // FLWLYTBTNSMOVE
            // 
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRX);
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRY);
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRZ);
            this.FLWLYTBTNSMOVE.Location = new System.Drawing.Point(467, 94);
            this.FLWLYTBTNSMOVE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FLWLYTBTNSMOVE.Name = "FLWLYTBTNSMOVE";
            this.FLWLYTBTNSMOVE.Size = new System.Drawing.Size(537, 107);
            this.FLWLYTBTNSMOVE.TabIndex = 1;
            // 
            // BTNRX
            // 
            this.BTNRX.BackColor = System.Drawing.Color.Tomato;
            this.BTNRX.ForeColor = System.Drawing.Color.Snow;
            this.BTNRX.Location = new System.Drawing.Point(5, 4);
            this.BTNRX.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNRX.Name = "BTNRX";
            this.BTNRX.Size = new System.Drawing.Size(163, 94);
            this.BTNRX.TabIndex = 0;
            this.BTNRX.Text = "RX";
            this.BTNRX.UseVisualStyleBackColor = false;
            this.BTNRX.Click += new System.EventHandler(this.BTNRX_Click);
            // 
            // BTNRY
            // 
            this.BTNRY.BackColor = System.Drawing.Color.Tomato;
            this.BTNRY.ForeColor = System.Drawing.Color.Snow;
            this.BTNRY.Location = new System.Drawing.Point(178, 4);
            this.BTNRY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNRY.Name = "BTNRY";
            this.BTNRY.Size = new System.Drawing.Size(156, 94);
            this.BTNRY.TabIndex = 1;
            this.BTNRY.Text = "RY";
            this.BTNRY.UseVisualStyleBackColor = false;
            this.BTNRY.Click += new System.EventHandler(this.BTNRY_Click);
            // 
            // BTNRZ
            // 
            this.BTNRZ.BackColor = System.Drawing.Color.Tomato;
            this.BTNRZ.ForeColor = System.Drawing.Color.Snow;
            this.BTNRZ.Location = new System.Drawing.Point(344, 4);
            this.BTNRZ.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNRZ.Name = "BTNRZ";
            this.BTNRZ.Size = new System.Drawing.Size(159, 94);
            this.BTNRZ.TabIndex = 2;
            this.BTNRZ.Text = "RZ";
            this.BTNRZ.UseVisualStyleBackColor = false;
            this.BTNRZ.Click += new System.EventHandler(this.BTNRZ_Click);
            // 
            // PanelAnimation
            // 
            this.PanelAnimation.Controls.Add(this.BTN_ADDKEY);
            this.PanelAnimation.Controls.Add(this.BTN_PLAY);
            this.PanelAnimation.Location = new System.Drawing.Point(1377, 94);
            this.PanelAnimation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PanelAnimation.Name = "PanelAnimation";
            this.PanelAnimation.Size = new System.Drawing.Size(397, 107);
            this.PanelAnimation.TabIndex = 3;
            // 
            // BTN_ADDKEY
            // 
            this.BTN_ADDKEY.BackColor = System.Drawing.Color.Indigo;
            this.BTN_ADDKEY.ForeColor = System.Drawing.Color.Snow;
            this.BTN_ADDKEY.Location = new System.Drawing.Point(5, 4);
            this.BTN_ADDKEY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTN_ADDKEY.Name = "BTN_ADDKEY";
            this.BTN_ADDKEY.Size = new System.Drawing.Size(208, 94);
            this.BTN_ADDKEY.TabIndex = 0;
            this.BTN_ADDKEY.Text = "Record";
            this.BTN_ADDKEY.UseVisualStyleBackColor = false;
            this.BTN_ADDKEY.Click += new System.EventHandler(this.BTN_ADDKEY_Click);
            // 
            // BTN_PLAY
            // 
            this.BTN_PLAY.BackColor = System.Drawing.Color.Indigo;
            this.BTN_PLAY.ForeColor = System.Drawing.Color.Snow;
            this.BTN_PLAY.Location = new System.Drawing.Point(223, 4);
            this.BTN_PLAY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTN_PLAY.Name = "BTN_PLAY";
            this.BTN_PLAY.Size = new System.Drawing.Size(156, 94);
            this.BTN_PLAY.TabIndex = 1;
            this.BTN_PLAY.Text = "Play";
            this.BTN_PLAY.UseVisualStyleBackColor = false;
            this.BTN_PLAY.Click += new System.EventHandler(this.BTN_PLAY_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.BTNCRY);
            this.flowLayoutPanel3.Controls.Add(this.BTNCRZ);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2366, 103);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(513, 107);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // BTNCRX
            // 
            this.BTNCRX.BackColor = System.Drawing.Color.Peru;
            this.BTNCRX.ForeColor = System.Drawing.Color.Snow;
            this.BTNCRX.Location = new System.Drawing.Point(2061, 98);
            this.BTNCRX.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCRX.Name = "BTNCRX";
            this.BTNCRX.Size = new System.Drawing.Size(163, 94);
            this.BTNCRX.TabIndex = 0;
            this.BTNCRX.Text = "Brillo";
            this.BTNCRX.UseVisualStyleBackColor = false;
            this.BTNCRX.Click += new System.EventHandler(this.CRX_Click);
            // 
            // BTNCRY
            // 
            this.BTNCRY.BackColor = System.Drawing.Color.Peru;
            this.BTNCRY.ForeColor = System.Drawing.Color.Snow;
            this.BTNCRY.Location = new System.Drawing.Point(5, 4);
            this.BTNCRY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCRY.Name = "BTNCRY";
            this.BTNCRY.Size = new System.Drawing.Size(156, 94);
            this.BTNCRY.TabIndex = 1;
            this.BTNCRY.Text = "CRY";
            this.BTNCRY.UseVisualStyleBackColor = false;
            this.BTNCRY.Click += new System.EventHandler(this.BTNCRY_Click);
            // 
            // BTNCRZ
            // 
            this.BTNCRZ.BackColor = System.Drawing.Color.Peru;
            this.BTNCRZ.ForeColor = System.Drawing.Color.Snow;
            this.BTNCRZ.Location = new System.Drawing.Point(171, 4);
            this.BTNCRZ.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCRZ.Name = "BTNCRZ";
            this.BTNCRZ.Size = new System.Drawing.Size(159, 94);
            this.BTNCRZ.TabIndex = 2;
            this.BTNCRZ.Text = "CRZ";
            this.BTNCRZ.UseVisualStyleBackColor = false;
            this.BTNCRZ.Click += new System.EventHandler(this.BTNCRZ_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 10;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3281, 1700);
            this.Controls.Add(this.PNL_MAIN);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "MyForm";
            this.Text = "aaa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.MyForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.PNL_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.PNL_BOTTOM.ResumeLayout(false);
            this.PNL_BOTTOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_TIMELINE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_MOVIE)).EndInit();
            this.PNL_HEADER.ResumeLayout(false);
            this.PNL_HEADER.PerformLayout();
            this.FLWLYTBTNSMOVE.ResumeLayout(false);
            this.PanelAnimation.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MAIN;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PNL_BOTTOM;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Panel PNL_HEADER;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button BTNOBJ;
        private System.Windows.Forms.Button BTNCUBE;
        private System.Windows.Forms.Button BTNSPHERE;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel FLWLYTBTNSMOVE;
        private System.Windows.Forms.Button BTNRX;
        private System.Windows.Forms.Button BTNRY;
        private System.Windows.Forms.Button BTNRZ;
        private System.Windows.Forms.Label LBLTREEVIEW;
        private System.Windows.Forms.Label LBLRENDERMODE;
        private System.Windows.Forms.RadioButton RDBTNWIREFRAME;
        private System.Windows.Forms.RadioButton RDBTNSOLID;
        private System.Windows.Forms.RadioButton RDBTNSHADED;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BTNLIGHT;
        private System.Windows.Forms.Label LBLLIGHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBINTENSITY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLCAMARA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BTNCRX;
        private System.Windows.Forms.Button BTNCRY;
        private System.Windows.Forms.Button BTNCRZ;
        private System.Windows.Forms.Label LBLTYPE;
        private System.Windows.Forms.RadioButton RDBTNAMBIENT;
        private System.Windows.Forms.RadioButton RDBTNPOINT;
        private System.Windows.Forms.RadioButton RDBTNDIRECTION;
        private System.Windows.Forms.TreeView TVLIGHTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel PanelAnimation;
        private System.Windows.Forms.Button BTN_ADDKEY;
        private System.Windows.Forms.Button BTN_PLAY;
        private System.Windows.Forms.PictureBox PCT_TIMELINE;
        private System.Windows.Forms.TrackBar TRK_MOVIE;
    }
}

