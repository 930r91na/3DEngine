﻿using System.Drawing;

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
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            this.Triangle = new System.Windows.Forms.Button();
            this.FLWLYTBTNSMOVE = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNRX = new System.Windows.Forms.Button();
            this.BTNRY = new System.Windows.Forms.Button();
            this.BTNRZ = new System.Windows.Forms.Button();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.TVLIGHTS = new System.Windows.Forms.TreeView();
            this.LBLLIGHT = new System.Windows.Forms.Label();
            this.BTNLIGHT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBINTENSITY = new System.Windows.Forms.TextBox();
            this.PNL_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PNL_HEADER.SuspendLayout();
            this.FLWLYTBTNSMOVE.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.PNL_MAIN.Size = new System.Drawing.Size(1875, 801);
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
            this.PCT_CANVAS.Size = new System.Drawing.Size(1379, 597);
            this.PCT_CANVAS.TabIndex = 6;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.Click += new System.EventHandler(this.PCT_CANVAS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1646, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 597);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 597);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 559);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BTNOBJ
            // 
            this.BTNOBJ.BackColor = System.Drawing.Color.DarkRed;
            this.BTNOBJ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNOBJ.Location = new System.Drawing.Point(3, 3);
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
            this.BTNCUBE.Location = new System.Drawing.Point(3, 52);
            this.BTNCUBE.Name = "BTNCUBE";
            this.BTNCUBE.Size = new System.Drawing.Size(114, 43);
            this.BTNCUBE.TabIndex = 1;
            this.BTNCUBE.Text = "Cube";
            this.BTNCUBE.UseVisualStyleBackColor = false;
            this.BTNCUBE.Click += new System.EventHandler(this.BTNCUBE_Click);
            // 
            // BTNSPHERE
            // 
            this.BTNSPHERE.BackColor = System.Drawing.Color.DarkRed;
            this.BTNSPHERE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNSPHERE.Location = new System.Drawing.Point(123, 52);
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
            this.LBLTREEVIEW.Location = new System.Drawing.Point(3, 98);
            this.LBLTREEVIEW.Name = "LBLTREEVIEW";
            this.LBLTREEVIEW.Size = new System.Drawing.Size(105, 29);
            this.LBLTREEVIEW.TabIndex = 6;
            this.LBLTREEVIEW.Text = "Models: ";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(3, 130);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(223, 237);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // LBLRENDERMODE
            // 
            this.LBLRENDERMODE.AutoSize = true;
            this.LBLRENDERMODE.Location = new System.Drawing.Point(3, 370);
            this.LBLRENDERMODE.Name = "LBLRENDERMODE";
            this.LBLRENDERMODE.Size = new System.Drawing.Size(167, 29);
            this.LBLRENDERMODE.TabIndex = 7;
            this.LBLRENDERMODE.Text = "Render Mode:";
            // 
            // RDBTNWIREFRAME
            // 
            this.RDBTNWIREFRAME.AutoSize = true;
            this.RDBTNWIREFRAME.Location = new System.Drawing.Point(3, 402);
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
            this.RDBTNSOLID.Location = new System.Drawing.Point(3, 441);
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
            this.RDBTNSHADED.Location = new System.Drawing.Point(3, 480);
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
            this.PNL_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 720);
            this.PNL_BOTTOM.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(1875, 53);
            this.PNL_BOTTOM.TabIndex = 3;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_STATUS.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.Location = new System.Drawing.Point(0, 773);
            this.LBL_STATUS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(1875, 28);
            this.LBL_STATUS.TabIndex = 2;
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_HEADER.Controls.Add(this.Triangle);
            this.PNL_HEADER.Controls.Add(this.FLWLYTBTNSMOVE);
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(1875, 123);
            this.PNL_HEADER.TabIndex = 0;
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(117, 52);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(75, 47);
            this.Triangle.TabIndex = 5;
            this.Triangle.Text = "T";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // FLWLYTBTNSMOVE
            // 
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRX);
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRY);
            this.FLWLYTBTNSMOVE.Controls.Add(this.BTNRZ);
            this.FLWLYTBTNSMOVE.Location = new System.Drawing.Point(267, 34);
            this.FLWLYTBTNSMOVE.Name = "FLWLYTBTNSMOVE";
            this.FLWLYTBTNSMOVE.Size = new System.Drawing.Size(502, 65);
            this.FLWLYTBTNSMOVE.TabIndex = 1;
            // 
            // BTNRX
            // 
            this.BTNRX.BackColor = System.Drawing.Color.Tomato;
            this.BTNRX.ForeColor = System.Drawing.Color.Snow;
            this.BTNRX.Location = new System.Drawing.Point(3, 3);
            this.BTNRX.Name = "BTNRX";
            this.BTNRX.Size = new System.Drawing.Size(154, 52);
            this.BTNRX.TabIndex = 0;
            this.BTNRX.Text = "RX";
            this.BTNRX.UseVisualStyleBackColor = false;
            this.BTNRX.Click += new System.EventHandler(this.BTNRX_Click);
            // 
            // BTNRY
            // 
            this.BTNRY.BackColor = System.Drawing.Color.Tomato;
            this.BTNRY.ForeColor = System.Drawing.Color.Snow;
            this.BTNRY.Location = new System.Drawing.Point(163, 3);
            this.BTNRY.Name = "BTNRY";
            this.BTNRY.Size = new System.Drawing.Size(154, 52);
            this.BTNRY.TabIndex = 1;
            this.BTNRY.Text = "RY";
            this.BTNRY.UseVisualStyleBackColor = false;
            this.BTNRY.Click += new System.EventHandler(this.BTNRY_Click);
            // 
            // BTNRZ
            // 
            this.BTNRZ.BackColor = System.Drawing.Color.Tomato;
            this.BTNRZ.ForeColor = System.Drawing.Color.Snow;
            this.BTNRZ.Location = new System.Drawing.Point(323, 3);
            this.BTNRZ.Name = "BTNRZ";
            this.BTNRZ.Size = new System.Drawing.Size(154, 52);
            this.BTNRZ.TabIndex = 2;
            this.BTNRZ.Text = "RZ";
            this.BTNRZ.UseVisualStyleBackColor = false;
            this.BTNRZ.Click += new System.EventHandler(this.BTNRZ_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 10;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.TBINTENSITY);
            this.flowLayoutPanel2.Controls.Add(this.BTNLIGHT);
            this.flowLayoutPanel2.Controls.Add(this.LBLLIGHT);
            this.flowLayoutPanel2.Controls.Add(this.TVLIGHTS);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(215, 559);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // TVLIGHTS
            // 
            this.TVLIGHTS.BackColor = System.Drawing.Color.Black;
            this.TVLIGHTS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TVLIGHTS.Location = new System.Drawing.Point(3, 130);
            this.TVLIGHTS.Name = "TVLIGHTS";
            this.TVLIGHTS.Size = new System.Drawing.Size(207, 280);
            this.TVLIGHTS.TabIndex = 0;
            this.TVLIGHTS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVLIGHTS_AfterSelect);
            // 
            // LBLLIGHT
            // 
            this.LBLLIGHT.AutoSize = true;
            this.LBLLIGHT.Location = new System.Drawing.Point(3, 98);
            this.LBLLIGHT.Name = "LBLLIGHT";
            this.LBLLIGHT.Size = new System.Drawing.Size(83, 29);
            this.LBLLIGHT.TabIndex = 1;
            this.LBLLIGHT.Text = "Lights:";
            // 
            // BTNLIGHT
            // 
            this.BTNLIGHT.BackColor = System.Drawing.Color.Navy;
            this.BTNLIGHT.Location = new System.Drawing.Point(3, 43);
            this.BTNLIGHT.Name = "BTNLIGHT";
            this.BTNLIGHT.Size = new System.Drawing.Size(207, 52);
            this.BTNLIGHT.TabIndex = 2;
            this.BTNLIGHT.Text = "Add Light";
            this.BTNLIGHT.UseVisualStyleBackColor = false;
            this.BTNLIGHT.Click += new System.EventHandler(this.BTNLIGHT_Click);
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
            this.TBINTENSITY.Location = new System.Drawing.Point(115, 3);
            this.TBINTENSITY.Name = "TBINTENSITY";
            this.TBINTENSITY.Size = new System.Drawing.Size(67, 34);
            this.TBINTENSITY.TabIndex = 4;
            this.TBINTENSITY.TextChanged += new System.EventHandler(this.TBINTENSITY_TextChanged);
            this.TBINTENSITY.Text = "0.1";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 801);
            this.Controls.Add(this.PNL_MAIN);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyForm";
            this.Text = "PLAYGROUND || VERLETS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.MyForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.PNL_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.PNL_HEADER.ResumeLayout(false);
            this.FLWLYTBTNSMOVE.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TreeView TVLIGHTS;
        private System.Windows.Forms.Button BTNLIGHT;
        private System.Windows.Forms.Label LBLLIGHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBINTENSITY;
    }
}

