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
            this.BTNDLKF = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNBW = new System.Windows.Forms.Button();
            this.BTNINVERSE = new System.Windows.Forms.Button();
            this.BTNGRYS = new System.Windows.Forms.Button();
            this.BTNSEPIA = new System.Windows.Forms.Button();
            this.BTNBRIGHTNESS = new System.Windows.Forms.Button();
            this.BTNTW = new System.Windows.Forms.Button();
            this.BTNBLUR = new System.Windows.Forms.Button();
            this.BTNHEDGES = new System.Windows.Forms.Button();
            this.BTNDLFILTRS = new System.Windows.Forms.Button();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.BTNSMOOTHING = new System.Windows.Forms.Button();
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
            this.PNL_MAIN.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_MAIN.Name = "PNL_MAIN";
            this.PNL_MAIN.Size = new System.Drawing.Size(1924, 932);
            this.PNL_MAIN.TabIndex = 0;
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PCT_CANVAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCT_CANVAS.Location = new System.Drawing.Point(267, 123);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_CANVAS.MinimumSize = new System.Drawing.Size(100, 50);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1428, 654);
            this.PCT_CANVAS.TabIndex = 6;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.Click += new System.EventHandler(this.PCT_CANVAS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1695, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 654);
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
            this.flowLayoutPanel2.Controls.Add(this.RDBTNPOINT);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 17);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(215, 559);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Intensity:";
            // 
            // TBINTENSITY
            // 
            this.TBINTENSITY.Location = new System.Drawing.Point(115, 2);
            this.TBINTENSITY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBINTENSITY.Name = "TBINTENSITY";
            this.TBINTENSITY.Size = new System.Drawing.Size(67, 34);
            this.TBINTENSITY.TabIndex = 4;
            this.TBINTENSITY.Text = "0.1";
            this.TBINTENSITY.TextChanged += new System.EventHandler(this.TBINTENSITY_TextChanged);
            // 
            // BTNLIGHT
            // 
            this.BTNLIGHT.BackColor = System.Drawing.Color.Navy;
            this.BTNLIGHT.Location = new System.Drawing.Point(3, 40);
            this.BTNLIGHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNLIGHT.Name = "BTNLIGHT";
            this.BTNLIGHT.Size = new System.Drawing.Size(207, 52);
            this.BTNLIGHT.TabIndex = 2;
            this.BTNLIGHT.Text = "Add Light";
            this.BTNLIGHT.UseVisualStyleBackColor = false;
            this.BTNLIGHT.Click += new System.EventHandler(this.BTNLIGHT_Click);
            // 
            // LBLLIGHT
            // 
            this.LBLLIGHT.AutoSize = true;
            this.LBLLIGHT.Location = new System.Drawing.Point(3, 94);
            this.LBLLIGHT.Name = "LBLLIGHT";
            this.LBLLIGHT.Size = new System.Drawing.Size(83, 29);
            this.LBLLIGHT.TabIndex = 1;
            this.LBLLIGHT.Text = "Lights:";
            // 
            // TVLIGHTS
            // 
            this.TVLIGHTS.BackColor = System.Drawing.Color.Black;
            this.TVLIGHTS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TVLIGHTS.Location = new System.Drawing.Point(3, 125);
            this.TVLIGHTS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVLIGHTS.Name = "TVLIGHTS";
            this.TVLIGHTS.Size = new System.Drawing.Size(207, 280);
            this.TVLIGHTS.TabIndex = 0;
            this.TVLIGHTS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVLIGHTS_AfterSelect);
            // 
            // LBLTYPE
            // 
            this.LBLTYPE.AutoSize = true;
            this.LBLTYPE.Location = new System.Drawing.Point(3, 407);
            this.LBLTYPE.Name = "LBLTYPE";
            this.LBLTYPE.Size = new System.Drawing.Size(140, 29);
            this.LBLTYPE.TabIndex = 5;
            this.LBLTYPE.Text = "Type:           ";
            // 
            // RDBTNAMBIENT
            // 
            this.RDBTNAMBIENT.AutoSize = true;
            this.RDBTNAMBIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBTNAMBIENT.Location = new System.Drawing.Point(3, 438);
            this.RDBTNAMBIENT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDBTNAMBIENT.Name = "RDBTNAMBIENT";
            this.RDBTNAMBIENT.Size = new System.Drawing.Size(122, 33);
            this.RDBTNAMBIENT.TabIndex = 6;
            this.RDBTNAMBIENT.TabStop = true;
            this.RDBTNAMBIENT.Text = "Ambient";
            this.RDBTNAMBIENT.UseVisualStyleBackColor = true;
            this.RDBTNAMBIENT.CheckedChanged += new System.EventHandler(this.RDBTNAMBIENT_CheckedChanged);
            // 
            // RDBTNPOINT
            // 
            this.RDBTNPOINT.AutoSize = true;
            this.RDBTNPOINT.Location = new System.Drawing.Point(3, 475);
            this.RDBTNPOINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDBTNPOINT.Name = "RDBTNPOINT";
            this.RDBTNPOINT.Size = new System.Drawing.Size(89, 33);
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
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 654);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 17);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 559);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BTNOBJ
            // 
            this.BTNOBJ.BackColor = System.Drawing.Color.DarkRed;
            this.BTNOBJ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNOBJ.Location = new System.Drawing.Point(3, 2);
            this.BTNOBJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNOBJ.Name = "BTNOBJ";
            this.BTNOBJ.Size = new System.Drawing.Size(223, 43);
            this.BTNOBJ.TabIndex = 0;
            this.BTNOBJ.Text = "UPLOAD OBJ";
            this.BTNOBJ.UseVisualStyleBackColor = false;
            this.BTNOBJ.Click += new System.EventHandler(this.BTNOBJ_Click);
            // 
            // BTNCUBE
            // 
            this.BTNCUBE.BackColor = System.Drawing.Color.DarkRed;
            this.BTNCUBE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNCUBE.Location = new System.Drawing.Point(3, 49);
            this.BTNCUBE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNCUBE.Name = "BTNCUBE";
            this.BTNCUBE.Size = new System.Drawing.Size(115, 43);
            this.BTNCUBE.TabIndex = 1;
            this.BTNCUBE.Text = "Cube";
            this.BTNCUBE.UseVisualStyleBackColor = false;
            this.BTNCUBE.Click += new System.EventHandler(this.BTNCUBE_Click);
            // 
            // BTNSPHERE
            // 
            this.BTNSPHERE.BackColor = System.Drawing.Color.DarkRed;
            this.BTNSPHERE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNSPHERE.Location = new System.Drawing.Point(124, 49);
            this.BTNSPHERE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNSPHERE.Name = "BTNSPHERE";
            this.BTNSPHERE.Size = new System.Drawing.Size(103, 43);
            this.BTNSPHERE.TabIndex = 2;
            this.BTNSPHERE.Text = "Sphere";
            this.BTNSPHERE.UseVisualStyleBackColor = false;
            this.BTNSPHERE.Click += new System.EventHandler(this.BTNSPHERE_Click);
            // 
            // LBLTREEVIEW
            // 
            this.LBLTREEVIEW.AutoSize = true;
            this.LBLTREEVIEW.Location = new System.Drawing.Point(3, 94);
            this.LBLTREEVIEW.Name = "LBLTREEVIEW";
            this.LBLTREEVIEW.Size = new System.Drawing.Size(105, 29);
            this.LBLTREEVIEW.TabIndex = 6;
            this.LBLTREEVIEW.Text = "Models: ";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(3, 125);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(223, 237);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // LBLRENDERMODE
            // 
            this.LBLRENDERMODE.AutoSize = true;
            this.LBLRENDERMODE.Location = new System.Drawing.Point(3, 364);
            this.LBLRENDERMODE.Name = "LBLRENDERMODE";
            this.LBLRENDERMODE.Size = new System.Drawing.Size(167, 29);
            this.LBLRENDERMODE.TabIndex = 7;
            this.LBLRENDERMODE.Text = "Render Mode:";
            // 
            // RDBTNWIREFRAME
            // 
            this.RDBTNWIREFRAME.AutoSize = true;
            this.RDBTNWIREFRAME.Location = new System.Drawing.Point(3, 395);
            this.RDBTNWIREFRAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDBTNWIREFRAME.Name = "RDBTNWIREFRAME";
            this.RDBTNWIREFRAME.Size = new System.Drawing.Size(145, 33);
            this.RDBTNWIREFRAME.TabIndex = 3;
            this.RDBTNWIREFRAME.TabStop = true;
            this.RDBTNWIREFRAME.Text = "Wireframe";
            this.RDBTNWIREFRAME.UseVisualStyleBackColor = true;
            this.RDBTNWIREFRAME.CheckedChanged += new System.EventHandler(this.RDBTNWIREFRAME_CheckedChanged);
            // 
            // RDBTNSOLID
            // 
            this.RDBTNSOLID.AutoSize = true;
            this.RDBTNSOLID.Location = new System.Drawing.Point(3, 432);
            this.RDBTNSOLID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDBTNSOLID.Name = "RDBTNSOLID";
            this.RDBTNSOLID.Size = new System.Drawing.Size(108, 33);
            this.RDBTNSOLID.TabIndex = 4;
            this.RDBTNSOLID.TabStop = true;
            this.RDBTNSOLID.Text = "Solid   ";
            this.RDBTNSOLID.UseVisualStyleBackColor = true;
            this.RDBTNSOLID.CheckedChanged += new System.EventHandler(this.RDBTNSOLID_CheckedChanged);
            // 
            // RDBTNSHADED
            // 
            this.RDBTNSHADED.AutoSize = true;
            this.RDBTNSHADED.Location = new System.Drawing.Point(3, 469);
            this.RDBTNSHADED.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDBTNSHADED.Name = "RDBTNSHADED";
            this.RDBTNSHADED.Size = new System.Drawing.Size(118, 33);
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
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 777);
            this.PNL_BOTTOM.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(1924, 127);
            this.PNL_BOTTOM.TabIndex = 3;
            // 
            // PCT_TIMELINE
            // 
            this.PCT_TIMELINE.Location = new System.Drawing.Point(372, 56);
            this.PCT_TIMELINE.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_TIMELINE.Name = "PCT_TIMELINE";
            this.PCT_TIMELINE.Size = new System.Drawing.Size(1153, 52);
            this.PCT_TIMELINE.TabIndex = 1;
            this.PCT_TIMELINE.TabStop = false;
            this.PCT_TIMELINE.Click += new System.EventHandler(this.PCT_TIMELINE_Click);
            // 
            // TRK_MOVIE
            // 
            this.TRK_MOVIE.Location = new System.Drawing.Point(372, 18);
            this.TRK_MOVIE.Margin = new System.Windows.Forms.Padding(4);
            this.TRK_MOVIE.Maximum = 30;
            this.TRK_MOVIE.Name = "TRK_MOVIE";
            this.TRK_MOVIE.Size = new System.Drawing.Size(1153, 56);
            this.TRK_MOVIE.TabIndex = 0;
            this.TRK_MOVIE.Scroll += new System.EventHandler(this.TRK_MOVIE_Scroll);
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_STATUS.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.Location = new System.Drawing.Point(0, 904);
            this.LBL_STATUS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(1924, 28);
            this.LBL_STATUS.TabIndex = 2;
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_HEADER.Controls.Add(this.label3);
            this.PNL_HEADER.Controls.Add(this.LBLCAMARA);
            this.PNL_HEADER.Controls.Add(this.label2);
            this.PNL_HEADER.Controls.Add(this.FLWLYTBTNSMOVE);
            this.PNL_HEADER.Controls.Add(this.PanelAnimation);
            this.PNL_HEADER.Controls.Add(this.flowLayoutPanel3);
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(1924, 123);
            this.PNL_HEADER.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Animation:";
            // 
            // LBLCAMARA
            // 
            this.LBLCAMARA.AutoSize = true;
            this.LBLCAMARA.Location = new System.Drawing.Point(651, 11);
            this.LBLCAMARA.Name = "LBLCAMARA";
            this.LBLCAMARA.Size = new System.Drawing.Size(86, 29);
            this.LBLCAMARA.TabIndex = 7;
            this.LBLCAMARA.Text = "Filters:";
            this.LBLCAMARA.Click += new System.EventHandler(this.LBLCAMARA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model: ";
            // 
            // FLWLYTBTNSMOVE
            // 
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRX);
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRY);
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRZ);
            this.FLWLYTBTNSMOVE.Location = new System.Drawing.Point(21, 42);
            this.FLWLYTBTNSMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLWLYTBTNSMOVE.Name = "FLWLYTBTNSMOVE";
            this.FLWLYTBTNSMOVE.Size = new System.Drawing.Size(212, 59);
            this.FLWLYTBTNSMOVE.TabIndex = 1;
            // 
            // BTNRX
            // 
            this.BTNRX.BackColor = System.Drawing.Color.Tomato;
            this.BTNRX.ForeColor = System.Drawing.Color.Snow;
            this.BTNRX.Location = new System.Drawing.Point(3, 2);
            this.BTNRX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNRX.Name = "BTNRX";
            this.BTNRX.Size = new System.Drawing.Size(63, 52);
            this.BTNRX.TabIndex = 0;
            this.BTNRX.Text = "RX";
            this.BTNRX.UseVisualStyleBackColor = false;
            this.BTNRX.Click += new System.EventHandler(this.BTNRX_Click);
            // 
            // BTNRY
            // 
            this.BTNRY.BackColor = System.Drawing.Color.Tomato;
            this.BTNRY.ForeColor = System.Drawing.Color.Snow;
            this.BTNRY.Location = new System.Drawing.Point(72, 2);
            this.BTNRY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNRY.Name = "BTNRY";
            this.BTNRY.Size = new System.Drawing.Size(64, 52);
            this.BTNRY.TabIndex = 1;
            this.BTNRY.Text = "RY";
            this.BTNRY.UseVisualStyleBackColor = false;
            this.BTNRY.Click += new System.EventHandler(this.BTNRY_Click);
            // 
            // BTNRZ
            // 
            this.BTNRZ.BackColor = System.Drawing.Color.Tomato;
            this.BTNRZ.ForeColor = System.Drawing.Color.Snow;
            this.BTNRZ.Location = new System.Drawing.Point(142, 2);
            this.BTNRZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNRZ.Name = "BTNRZ";
            this.BTNRZ.Size = new System.Drawing.Size(57, 52);
            this.BTNRZ.TabIndex = 2;
            this.BTNRZ.Text = "RZ";
            this.BTNRZ.UseVisualStyleBackColor = false;
            this.BTNRZ.Click += new System.EventHandler(this.BTNRZ_Click);
            // 
            // PanelAnimation
            // 
            this.PanelAnimation.Controls.Add(this.BTN_ADDKEY);
            this.PanelAnimation.Controls.Add(this.BTN_PLAY);
            this.PanelAnimation.Controls.Add(this.BTNDLKF);
            this.PanelAnimation.Location = new System.Drawing.Point(252, 39);
            this.PanelAnimation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelAnimation.Name = "PanelAnimation";
            this.PanelAnimation.Size = new System.Drawing.Size(370, 59);
            this.PanelAnimation.TabIndex = 3;
            // 
            // BTN_ADDKEY
            // 
            this.BTN_ADDKEY.BackColor = System.Drawing.Color.Indigo;
            this.BTN_ADDKEY.ForeColor = System.Drawing.Color.Snow;
            this.BTN_ADDKEY.Location = new System.Drawing.Point(3, 2);
            this.BTN_ADDKEY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ADDKEY.Name = "BTN_ADDKEY";
            this.BTN_ADDKEY.Size = new System.Drawing.Size(119, 52);
            this.BTN_ADDKEY.TabIndex = 0;
            this.BTN_ADDKEY.Text = "Record";
            this.BTN_ADDKEY.UseVisualStyleBackColor = false;
            this.BTN_ADDKEY.Click += new System.EventHandler(this.BTN_ADDKEY_Click);
            // 
            // BTN_PLAY
            // 
            this.BTN_PLAY.BackColor = System.Drawing.Color.Indigo;
            this.BTN_PLAY.ForeColor = System.Drawing.Color.Snow;
            this.BTN_PLAY.Location = new System.Drawing.Point(128, 2);
            this.BTN_PLAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_PLAY.Name = "BTN_PLAY";
            this.BTN_PLAY.Size = new System.Drawing.Size(89, 52);
            this.BTN_PLAY.TabIndex = 1;
            this.BTN_PLAY.Text = "Play";
            this.BTN_PLAY.UseVisualStyleBackColor = false;
            this.BTN_PLAY.Click += new System.EventHandler(this.BTN_PLAY_Click);
            // 
            // BTNDLKF
            // 
            this.BTNDLKF.BackColor = System.Drawing.Color.Crimson;
            this.BTNDLKF.ForeColor = System.Drawing.Color.Snow;
            this.BTNDLKF.Location = new System.Drawing.Point(223, 2);
            this.BTNDLKF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDLKF.Name = "BTNDLKF";
            this.BTNDLKF.Size = new System.Drawing.Size(133, 52);
            this.BTNDLKF.TabIndex = 2;
            this.BTNDLKF.Text = "Delete KF";
            this.BTNDLKF.UseVisualStyleBackColor = false;
            this.BTNDLKF.Click += new System.EventHandler(this.BTNDLKF_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.BTNBW);
            this.flowLayoutPanel3.Controls.Add(this.BTNINVERSE);
            this.flowLayoutPanel3.Controls.Add(this.BTNGRYS);
            this.flowLayoutPanel3.Controls.Add(this.BTNSEPIA);
            this.flowLayoutPanel3.Controls.Add(this.BTNBRIGHTNESS);
            this.flowLayoutPanel3.Controls.Add(this.BTNTW);
            this.flowLayoutPanel3.Controls.Add(this.BTNBLUR);
            this.flowLayoutPanel3.Controls.Add(this.BTNHEDGES);
            this.flowLayoutPanel3.Controls.Add(this.BTNSMOOTHING);
            this.flowLayoutPanel3.Controls.Add(this.BTNDLFILTRS);
            this.flowLayoutPanel3.ForeColor = System.Drawing.Color.Tan;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(640, 37);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1233, 59);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // BTNBW
            // 
            this.BTNBW.BackColor = System.Drawing.Color.DeepPink;
            this.BTNBW.ForeColor = System.Drawing.Color.Snow;
            this.BTNBW.Location = new System.Drawing.Point(3, 2);
            this.BTNBW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNBW.Name = "BTNBW";
            this.BTNBW.Size = new System.Drawing.Size(94, 52);
            this.BTNBW.TabIndex = 1;
            this.BTNBW.Text = "B/W";
            this.BTNBW.UseVisualStyleBackColor = false;
            this.BTNBW.Click += new System.EventHandler(this.BTNBW_Click);
            // 
            // BTNINVERSE
            // 
            this.BTNINVERSE.BackColor = System.Drawing.Color.DeepPink;
            this.BTNINVERSE.ForeColor = System.Drawing.Color.Snow;
            this.BTNINVERSE.Location = new System.Drawing.Point(103, 2);
            this.BTNINVERSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNINVERSE.Name = "BTNINVERSE";
            this.BTNINVERSE.Size = new System.Drawing.Size(112, 52);
            this.BTNINVERSE.TabIndex = 7;
            this.BTNINVERSE.Text = "Inverse";
            this.BTNINVERSE.UseVisualStyleBackColor = false;
            this.BTNINVERSE.Click += new System.EventHandler(this.BTNINVERSE_Click);
            // 
            // BTNGRYS
            // 
            this.BTNGRYS.BackColor = System.Drawing.Color.DeepPink;
            this.BTNGRYS.ForeColor = System.Drawing.Color.Snow;
            this.BTNGRYS.Location = new System.Drawing.Point(221, 2);
            this.BTNGRYS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNGRYS.Name = "BTNGRYS";
            this.BTNGRYS.Size = new System.Drawing.Size(91, 52);
            this.BTNGRYS.TabIndex = 2;
            this.BTNGRYS.Text = "Grays";
            this.BTNGRYS.UseVisualStyleBackColor = false;
            this.BTNGRYS.Click += new System.EventHandler(this.BTNGRYS_Click);
            // 
            // BTNSEPIA
            // 
            this.BTNSEPIA.BackColor = System.Drawing.Color.DeepPink;
            this.BTNSEPIA.ForeColor = System.Drawing.Color.Snow;
            this.BTNSEPIA.Location = new System.Drawing.Point(318, 2);
            this.BTNSEPIA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNSEPIA.Name = "BTNSEPIA";
            this.BTNSEPIA.Size = new System.Drawing.Size(91, 52);
            this.BTNSEPIA.TabIndex = 6;
            this.BTNSEPIA.Text = "Sepia";
            this.BTNSEPIA.UseVisualStyleBackColor = false;
            this.BTNSEPIA.Click += new System.EventHandler(this.BTNSEPIA_Click);
            // 
            // BTNBRIGHTNESS
            // 
            this.BTNBRIGHTNESS.BackColor = System.Drawing.Color.DeepPink;
            this.BTNBRIGHTNESS.ForeColor = System.Drawing.Color.Snow;
            this.BTNBRIGHTNESS.Location = new System.Drawing.Point(415, 2);
            this.BTNBRIGHTNESS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNBRIGHTNESS.Name = "BTNBRIGHTNESS";
            this.BTNBRIGHTNESS.Size = new System.Drawing.Size(138, 52);
            this.BTNBRIGHTNESS.TabIndex = 0;
            this.BTNBRIGHTNESS.Text = "Brightness";
            this.BTNBRIGHTNESS.UseVisualStyleBackColor = false;
            this.BTNBRIGHTNESS.Click += new System.EventHandler(this.BTNBRIGHTNESS_Click);
            // 
            // BTNTW
            // 
            this.BTNTW.BackColor = System.Drawing.Color.DeepPink;
            this.BTNTW.ForeColor = System.Drawing.Color.Snow;
            this.BTNTW.Location = new System.Drawing.Point(559, 2);
            this.BTNTW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNTW.Name = "BTNTW";
            this.BTNTW.Size = new System.Drawing.Size(110, 52);
            this.BTNTW.TabIndex = 4;
            this.BTNTW.Text = "Twilight";
            this.BTNTW.UseVisualStyleBackColor = false;
            this.BTNTW.Click += new System.EventHandler(this.BTNTW_Click);
            // 
            // BTNBLUR
            // 
            this.BTNBLUR.BackColor = System.Drawing.Color.DeepPink;
            this.BTNBLUR.ForeColor = System.Drawing.Color.Snow;
            this.BTNBLUR.Location = new System.Drawing.Point(675, 2);
            this.BTNBLUR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNBLUR.Name = "BTNBLUR";
            this.BTNBLUR.Size = new System.Drawing.Size(67, 52);
            this.BTNBLUR.TabIndex = 3;
            this.BTNBLUR.Text = "Blur";
            this.BTNBLUR.UseVisualStyleBackColor = false;
            this.BTNBLUR.Click += new System.EventHandler(this.BTNBLUR_Click);
            // 
            // BTNHEDGES
            // 
            this.BTNHEDGES.BackColor = System.Drawing.Color.DeepPink;
            this.BTNHEDGES.ForeColor = System.Drawing.Color.Snow;
            this.BTNHEDGES.Location = new System.Drawing.Point(748, 2);
            this.BTNHEDGES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNHEDGES.Name = "BTNHEDGES";
            this.BTNHEDGES.Size = new System.Drawing.Size(103, 52);
            this.BTNHEDGES.TabIndex = 8;
            this.BTNHEDGES.Text = "Edges";
            this.BTNHEDGES.UseVisualStyleBackColor = false;
            this.BTNHEDGES.Click += new System.EventHandler(this.BTNHEDGES_Click);
            // 
            // BTNDLFILTRS
            // 
            this.BTNDLFILTRS.BackColor = System.Drawing.Color.Red;
            this.BTNDLFILTRS.ForeColor = System.Drawing.Color.Snow;
            this.BTNDLFILTRS.Location = new System.Drawing.Point(1024, 2);
            this.BTNDLFILTRS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDLFILTRS.Name = "BTNDLFILTRS";
            this.BTNDLFILTRS.Size = new System.Drawing.Size(206, 52);
            this.BTNDLFILTRS.TabIndex = 5;
            this.BTNDLFILTRS.Text = "FiltersOFF/ON";
            this.BTNDLFILTRS.UseVisualStyleBackColor = false;
            this.BTNDLFILTRS.Click += new System.EventHandler(this.BTNDLFILTRS_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 10;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // BTNSMOOTHING
            // 
            this.BTNSMOOTHING.BackColor = System.Drawing.Color.DeepPink;
            this.BTNSMOOTHING.ForeColor = System.Drawing.Color.Snow;
            this.BTNSMOOTHING.Location = new System.Drawing.Point(857, 2);
            this.BTNSMOOTHING.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNSMOOTHING.Name = "BTNSMOOTHING";
            this.BTNSMOOTHING.Size = new System.Drawing.Size(161, 52);
            this.BTNSMOOTHING.TabIndex = 9;
            this.BTNSMOOTHING.Text = "GSmoothing";
            this.BTNSMOOTHING.UseVisualStyleBackColor = false;
            this.BTNSMOOTHING.Click += new System.EventHandler(this.Smoothing_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 932);
            this.Controls.Add(this.PNL_MAIN);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button BTNBRIGHTNESS;
        private System.Windows.Forms.Button BTNBW;
        private System.Windows.Forms.Button BTNGRYS;
        private System.Windows.Forms.Label LBLTYPE;
        private System.Windows.Forms.RadioButton RDBTNAMBIENT;
        private System.Windows.Forms.RadioButton RDBTNPOINT;
        private System.Windows.Forms.TreeView TVLIGHTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel PanelAnimation;
        private System.Windows.Forms.Button BTN_ADDKEY;
        private System.Windows.Forms.Button BTN_PLAY;
        private System.Windows.Forms.PictureBox PCT_TIMELINE;
        private System.Windows.Forms.TrackBar TRK_MOVIE;
        private System.Windows.Forms.Button BTNBLUR;
        private System.Windows.Forms.Button BTNTW;
        private System.Windows.Forms.Button BTNDLKF;
        private System.Windows.Forms.Button BTNSEPIA;
        private System.Windows.Forms.Button BTNINVERSE;
        private System.Windows.Forms.Button BTNHEDGES;
        private System.Windows.Forms.Button BTNDLFILTRS;
        private System.Windows.Forms.Button BTNSMOOTHING;
    }
}

