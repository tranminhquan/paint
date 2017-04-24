namespace Paint
{
    partial class frmPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuTools = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnBucket = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelPaint = new System.Windows.Forms.Panel();
            this.picPaint = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTab = new System.Windows.Forms.Panel();
            this.pn_penWidth = new System.Windows.Forms.Panel();
            this.lb_penWidth = new System.Windows.Forms.Label();
            this.TB_penWidth = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHexagon = new System.Windows.Forms.Button();
            this.btnRhombus = new System.Windows.Forms.Button();
            this.btnPentagon = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.timerPanel = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panelMenuTools.SuspendLayout();
            this.panelPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaint)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pnlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_penWidth)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1914, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.saveAsToolStripMenuItem.Text = "Save As . . .";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.editToolStripMenuItem.Text = "Edits";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panelMenuTools
            // 
            this.panelMenuTools.BackColor = System.Drawing.Color.MediumBlue;
            this.panelMenuTools.Controls.Add(this.button8);
            this.panelMenuTools.Controls.Add(this.button7);
            this.panelMenuTools.Controls.Add(this.btnEraser);
            this.panelMenuTools.Controls.Add(this.btnPencil);
            this.panelMenuTools.Controls.Add(this.btnBucket);
            this.panelMenuTools.Controls.Add(this.button5);
            this.panelMenuTools.Controls.Add(this.button4);
            this.panelMenuTools.Controls.Add(this.button3);
            this.panelMenuTools.Controls.Add(this.button10);
            this.panelMenuTools.Controls.Add(this.button2);
            this.panelMenuTools.Controls.Add(this.button1);
            this.panelMenuTools.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMenuTools.Location = new System.Drawing.Point(0, 28);
            this.panelMenuTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuTools.Name = "panelMenuTools";
            this.panelMenuTools.Size = new System.Drawing.Size(1527, 70);
            this.panelMenuTools.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumBlue;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1451, 2);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 59);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumBlue;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1395, 2);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 59);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEraser.BackgroundImage")));
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEraser.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnEraser.FlatAppearance.BorderSize = 0;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.Location = new System.Drawing.Point(1283, 2);
            this.btnEraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(51, 59);
            this.btnEraser.TabIndex = 0;
            this.btnEraser.Tag = "Tool";
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPencil.BackgroundImage")));
            this.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPencil.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnPencil.FlatAppearance.BorderSize = 0;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.Location = new System.Drawing.Point(1188, 2);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(51, 59);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.Tag = "Tool";
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnBucket
            // 
            this.btnBucket.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBucket.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnBucket.FlatAppearance.BorderSize = 0;
            this.btnBucket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBucket.Location = new System.Drawing.Point(1111, 0);
            this.btnBucket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBucket.Name = "btnBucket";
            this.btnBucket.Size = new System.Drawing.Size(51, 59);
            this.btnBucket.TabIndex = 0;
            this.btnBucket.UseVisualStyleBackColor = false;
            this.btnBucket.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumBlue;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(437, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 59);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumBlue;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(359, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 59);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(273, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 59);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MediumBlue;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(101, 2);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 59);
            this.button10.TabIndex = 0;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumBlue;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(189, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 59);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(21, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 59);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInfo.BackColor = System.Drawing.Color.MediumBlue;
            this.panelInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelInfo.Location = new System.Drawing.Point(0, 741);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1527, 46);
            this.panelInfo.TabIndex = 2;
            // 
            // panelPaint
            // 
            this.panelPaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPaint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPaint.Controls.Add(this.picPaint);
            this.panelPaint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPaint.Location = new System.Drawing.Point(0, 94);
            this.panelPaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(1527, 647);
            this.panelPaint.TabIndex = 3;
            // 
            // picPaint
            // 
            this.picPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPaint.Location = new System.Drawing.Point(0, 0);
            this.picPaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPaint.Name = "picPaint";
            this.picPaint.Size = new System.Drawing.Size(1527, 647);
            this.picPaint.TabIndex = 0;
            this.picPaint.TabStop = false;
            this.picPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.picPaint_Paint);
            this.picPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPaint_MouseDown);
            this.picPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPaint_MouseMove);
            this.picPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPaint_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "HGdslgpmsg";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Navy;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1914, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pnlTab
            // 
            this.pnlTab.Controls.Add(this.pn_penWidth);
            this.pnlTab.Controls.Add(this.lb_penWidth);
            this.pnlTab.Controls.Add(this.TB_penWidth);
            this.pnlTab.Controls.Add(this.panel3);
            this.pnlTab.Controls.Add(this.panel2);
            this.pnlTab.Controls.Add(this.panel1);
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTab.Location = new System.Drawing.Point(1533, 28);
            this.pnlTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(381, 688);
            this.pnlTab.TabIndex = 6;
            // 
            // pn_penWidth
            // 
            this.pn_penWidth.BackColor = System.Drawing.Color.White;
            this.pn_penWidth.Location = new System.Drawing.Point(276, 14);
            this.pn_penWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_penWidth.Name = "pn_penWidth";
            this.pn_penWidth.Size = new System.Drawing.Size(93, 46);
            this.pn_penWidth.TabIndex = 4;
            this.pn_penWidth.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_penWidth_Paint);
            // 
            // lb_penWidth
            // 
            this.lb_penWidth.AutoSize = true;
            this.lb_penWidth.Location = new System.Drawing.Point(243, 23);
            this.lb_penWidth.Name = "lb_penWidth";
            this.lb_penWidth.Size = new System.Drawing.Size(16, 17);
            this.lb_penWidth.TabIndex = 3;
            this.lb_penWidth.Text = "1";
            // 
            // TB_penWidth
            // 
            this.TB_penWidth.Location = new System.Drawing.Point(13, 14);
            this.TB_penWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_penWidth.Minimum = 1;
            this.TB_penWidth.Name = "TB_penWidth";
            this.TB_penWidth.Size = new System.Drawing.Size(223, 56);
            this.TB_penWidth.TabIndex = 2;
            this.TB_penWidth.Value = 1;
            this.TB_penWidth.Scroll += new System.EventHandler(this.TB_penWidth_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(343, 498);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 178);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.pnlTab_Click);
            this.panel3.MouseLeave += new System.EventHandler(this.pnlTab_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnHexagon);
            this.panel6.Controls.Add(this.btnRhombus);
            this.panel6.Controls.Add(this.btnPentagon);
            this.panel6.Controls.Add(this.btnLine);
            this.panel6.Controls.Add(this.btnTriangle);
            this.panel6.Controls.Add(this.btnStar);
            this.panel6.Controls.Add(this.btnCircle);
            this.panel6.Controls.Add(this.btnRectangle);
            this.panel6.Location = new System.Drawing.Point(69, 14);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(427, 150);
            this.panel6.TabIndex = 0;
            // 
            // btnHexagon
            // 
            this.btnHexagon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHexagon.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnHexagon.FlatAppearance.BorderSize = 0;
            this.btnHexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHexagon.Location = new System.Drawing.Point(260, 78);
            this.btnHexagon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(69, 69);
            this.btnHexagon.TabIndex = 1;
            this.btnHexagon.Tag = "Tool";
            this.btnHexagon.UseVisualStyleBackColor = false;
            this.btnHexagon.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnRhombus
            // 
            this.btnRhombus.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRhombus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRhombus.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnRhombus.FlatAppearance.BorderSize = 0;
            this.btnRhombus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRhombus.Location = new System.Drawing.Point(89, 78);
            this.btnRhombus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRhombus.Name = "btnRhombus";
            this.btnRhombus.Size = new System.Drawing.Size(69, 69);
            this.btnRhombus.TabIndex = 1;
            this.btnRhombus.Tag = "Tool";
            this.btnRhombus.UseVisualStyleBackColor = false;
            this.btnRhombus.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnPentagon
            // 
            this.btnPentagon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPentagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPentagon.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnPentagon.FlatAppearance.BorderSize = 0;
            this.btnPentagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPentagon.Location = new System.Drawing.Point(173, 78);
            this.btnPentagon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(69, 69);
            this.btnPentagon.TabIndex = 1;
            this.btnPentagon.Tag = "Tool";
            this.btnPentagon.UseVisualStyleBackColor = false;
            this.btnPentagon.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Location = new System.Drawing.Point(260, 0);
            this.btnLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(69, 69);
            this.btnLine.TabIndex = 1;
            this.btnLine.Tag = "Tool";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTriangle.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnTriangle.FlatAppearance.BorderSize = 0;
            this.btnTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangle.Location = new System.Drawing.Point(3, 78);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(69, 69);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.Tag = "Tool";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnStar
            // 
            this.btnStar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnStar.FlatAppearance.BorderSize = 0;
            this.btnStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar.Location = new System.Drawing.Point(173, 0);
            this.btnStar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(69, 69);
            this.btnStar.TabIndex = 1;
            this.btnStar.Tag = "Tool";
            this.btnStar.UseVisualStyleBackColor = false;
            this.btnStar.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnCircle.Image")));
            this.btnCircle.Location = new System.Drawing.Point(89, 0);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(69, 69);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Tag = "Tool";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRectangle.BackgroundImage")));
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(3, 0);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(69, 69);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Tag = "Tool";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(343, 318);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 178);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.pnlTab_Click);
            this.panel2.MouseLeave += new System.EventHandler(this.pnlTab_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button22);
            this.panel5.Controls.Add(this.button21);
            this.panel5.Controls.Add(this.button15);
            this.panel5.Controls.Add(this.button14);
            this.panel5.Controls.Add(this.button13);
            this.panel5.Controls.Add(this.button12);
            this.panel5.Controls.Add(this.button20);
            this.panel5.Controls.Add(this.button19);
            this.panel5.Controls.Add(this.button18);
            this.panel5.Controls.Add(this.button17);
            this.panel5.Controls.Add(this.button16);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Location = new System.Drawing.Point(69, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(427, 139);
            this.panel5.TabIndex = 0;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DodgerBlue;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(292, 66);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(51, 49);
            this.button22.TabIndex = 0;
            this.button22.Tag = "Tool";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DodgerBlue;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(292, 12);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(51, 49);
            this.button21.TabIndex = 0;
            this.button21.Tag = "Tool";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DodgerBlue;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(236, 12);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 49);
            this.button15.TabIndex = 0;
            this.button15.Tag = "Tool";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DodgerBlue;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(180, 12);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 49);
            this.button14.TabIndex = 0;
            this.button14.Tag = "Tool";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DodgerBlue;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(124, 12);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(51, 49);
            this.button13.TabIndex = 0;
            this.button13.Tag = "Tool";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DodgerBlue;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(68, 12);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(51, 49);
            this.button12.TabIndex = 0;
            this.button12.Tag = "Tool";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.DodgerBlue;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(236, 66);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(51, 49);
            this.button20.TabIndex = 0;
            this.button20.Tag = "Tool";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.DodgerBlue;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(180, 66);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(51, 49);
            this.button19.TabIndex = 0;
            this.button19.Tag = "Tool";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.DodgerBlue;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(124, 66);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(51, 49);
            this.button18.TabIndex = 0;
            this.button18.Tag = "Tool";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DodgerBlue;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(68, 66);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(51, 49);
            this.button17.TabIndex = 0;
            this.button17.Tag = "Tool";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DodgerBlue;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(12, 66);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(51, 49);
            this.button16.TabIndex = 0;
            this.button16.Tag = "Tool";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(12, 12);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 49);
            this.button9.TabIndex = 0;
            this.button9.Tag = "Tool";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(343, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 178);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.pnlTab_Click);
            this.panel1.MouseLeave += new System.EventHandler(this.pnlTab_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnColor);
            this.panel4.Controls.Add(this.btnCrop);
            this.panel4.Location = new System.Drawing.Point(69, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 139);
            this.panel4.TabIndex = 0;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(101, 12);
            this.btnColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(51, 59);
            this.btnColor.TabIndex = 1;
            this.btnColor.Tag = "Tool";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrop.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnCrop.FlatAppearance.BorderSize = 0;
            this.btnCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrop.Location = new System.Drawing.Point(12, 12);
            this.btnCrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(51, 59);
            this.btnCrop.TabIndex = 0;
            this.btnCrop.Tag = "Tool";
            this.btnCrop.UseVisualStyleBackColor = false;
            this.btnCrop.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // timerPanel
            // 
            this.timerPanel.Interval = 10;
            this.timerPanel.Tick += new System.EventHandler(this.timerPanel_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1914, 741);
            this.Controls.Add(this.pnlTab);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelPaint);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelMenuTools);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPaint";
            this.Text = "Absoluke Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenuTools.ResumeLayout(false);
            this.panelPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPaint)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlTab.ResumeLayout(false);
            this.pnlTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_penWidth)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenuTools;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.PictureBox picPaint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnlTab;
        private System.Windows.Forms.Timer timerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnHexagon;
        private System.Windows.Forms.Button btnRhombus;
        private System.Windows.Forms.Button btnPentagon;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnBucket;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar TB_penWidth;
        private System.Windows.Forms.Label lb_penWidth;
        private System.Windows.Forms.Panel pn_penWidth;
        private System.Windows.Forms.Button btnColor;
    }
}

