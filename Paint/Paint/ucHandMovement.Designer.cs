namespace Paint
{
    partial class ucHandMovement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picSkinCam = new System.Windows.Forms.PictureBox();
            this.picInputCam = new System.Windows.Forms.PictureBox();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblNote = new MetroFramework.Controls.MetroLabel();
            this.lblNumFinger = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pnlSetting = new MetroFramework.Controls.MetroPanel();
            this.pnlSettingInfo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblMaxCb = new MetroFramework.Controls.MetroLabel();
            this.lblMaxCr = new MetroFramework.Controls.MetroLabel();
            this.lblMinCb = new MetroFramework.Controls.MetroLabel();
            this.lblMinCr = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbMaxCb = new MetroFramework.Controls.MetroTrackBar();
            this.tbMinCb = new MetroFramework.Controls.MetroTrackBar();
            this.tbMaxCr = new MetroFramework.Controls.MetroTrackBar();
            this.tbMinCr = new MetroFramework.Controls.MetroTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInputCam)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.pnlSettingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSkinCam
            // 
            this.picSkinCam.Location = new System.Drawing.Point(17, 179);
            this.picSkinCam.Name = "picSkinCam";
            this.picSkinCam.Size = new System.Drawing.Size(363, 165);
            this.picSkinCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkinCam.TabIndex = 0;
            this.picSkinCam.TabStop = false;
            // 
            // picInputCam
            // 
            this.picInputCam.Location = new System.Drawing.Point(17, 8);
            this.picInputCam.Name = "picInputCam";
            this.picInputCam.Size = new System.Drawing.Size(363, 165);
            this.picInputCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInputCam.TabIndex = 0;
            this.picInputCam.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(324, 350);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.lblNote);
            this.metroPanel1.Controls.Add(this.lblNumFinger);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.pnlSetting);
            this.metroPanel1.Controls.Add(this.btnStart);
            this.metroPanel1.Controls.Add(this.picInputCam);
            this.metroPanel1.Controls.Add(this.picSkinCam);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(403, 463);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(49, 400);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 0);
            this.lblNote.TabIndex = 4;
            this.lblNote.UseCustomForeColor = true;
            // 
            // lblNumFinger
            // 
            this.lblNumFinger.AutoSize = true;
            this.lblNumFinger.Location = new System.Drawing.Point(254, 362);
            this.lblNumFinger.Name = "lblNumFinger";
            this.lblNumFinger.Size = new System.Drawing.Size(0, 0);
            this.lblNumFinger.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(82, 362);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(138, 20);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Number of finger(s): ";
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackgroundImage = global::Paint.Properties.Resources.settingIcon;
            this.pnlSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlSetting.HorizontalScrollbarBarColor = true;
            this.pnlSetting.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSetting.HorizontalScrollbarSize = 10;
            this.pnlSetting.Location = new System.Drawing.Point(17, 350);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(59, 41);
            this.pnlSetting.TabIndex = 2;
            this.pnlSetting.VerticalScrollbarBarColor = true;
            this.pnlSetting.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSetting.VerticalScrollbarSize = 10;
            this.pnlSetting.Click += new System.EventHandler(this.pnlSetting_Click);
            // 
            // pnlSettingInfo
            // 
            this.pnlSettingInfo.Controls.Add(this.metroLabel4);
            this.pnlSettingInfo.Controls.Add(this.metroLabel2);
            this.pnlSettingInfo.Controls.Add(this.metroLabel3);
            this.pnlSettingInfo.Controls.Add(this.lblMaxCb);
            this.pnlSettingInfo.Controls.Add(this.lblMaxCr);
            this.pnlSettingInfo.Controls.Add(this.lblMinCb);
            this.pnlSettingInfo.Controls.Add(this.lblMinCr);
            this.pnlSettingInfo.Controls.Add(this.metroLabel1);
            this.pnlSettingInfo.Controls.Add(this.tbMaxCb);
            this.pnlSettingInfo.Controls.Add(this.tbMinCb);
            this.pnlSettingInfo.Controls.Add(this.tbMaxCr);
            this.pnlSettingInfo.Controls.Add(this.tbMinCr);
            this.pnlSettingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettingInfo.HorizontalScrollbarBarColor = true;
            this.pnlSettingInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSettingInfo.HorizontalScrollbarSize = 10;
            this.pnlSettingInfo.Location = new System.Drawing.Point(0, 463);
            this.pnlSettingInfo.Name = "pnlSettingInfo";
            this.pnlSettingInfo.Size = new System.Drawing.Size(403, 91);
            this.pnlSettingInfo.TabIndex = 3;
            this.pnlSettingInfo.VerticalScrollbarBarColor = true;
            this.pnlSettingInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSettingInfo.VerticalScrollbarSize = 10;
            this.pnlSettingInfo.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(202, 62);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "maxCb";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "minCb";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(202, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "maxCr";
            // 
            // lblMaxCb
            // 
            this.lblMaxCb.AutoSize = true;
            this.lblMaxCb.Location = new System.Drawing.Point(345, 69);
            this.lblMaxCb.Name = "lblMaxCb";
            this.lblMaxCb.Size = new System.Drawing.Size(0, 0);
            this.lblMaxCb.TabIndex = 3;
            // 
            // lblMaxCr
            // 
            this.lblMaxCr.AutoSize = true;
            this.lblMaxCr.Location = new System.Drawing.Point(345, 22);
            this.lblMaxCr.Name = "lblMaxCr";
            this.lblMaxCr.Size = new System.Drawing.Size(0, 0);
            this.lblMaxCr.TabIndex = 3;
            // 
            // lblMinCb
            // 
            this.lblMinCb.AutoSize = true;
            this.lblMinCb.Location = new System.Drawing.Point(144, 62);
            this.lblMinCb.Name = "lblMinCb";
            this.lblMinCb.Size = new System.Drawing.Size(0, 0);
            this.lblMinCb.TabIndex = 3;
            // 
            // lblMinCr
            // 
            this.lblMinCr.AutoSize = true;
            this.lblMinCr.Location = new System.Drawing.Point(144, 15);
            this.lblMinCr.Name = "lblMinCr";
            this.lblMinCr.Size = new System.Drawing.Size(0, 0);
            this.lblMinCr.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "minCr";
            // 
            // tbMaxCb
            // 
            this.tbMaxCb.BackColor = System.Drawing.Color.Transparent;
            this.tbMaxCb.Location = new System.Drawing.Point(254, 62);
            this.tbMaxCb.Maximum = 255;
            this.tbMaxCb.Name = "tbMaxCb";
            this.tbMaxCb.Size = new System.Drawing.Size(85, 24);
            this.tbMaxCb.TabIndex = 2;
            this.tbMaxCb.Tag = "4";
            this.tbMaxCb.Text = "metroTrackBar1";
            this.tbMaxCb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Ycc_Scroll);
            // 
            // tbMinCb
            // 
            this.tbMinCb.BackColor = System.Drawing.Color.Transparent;
            this.tbMinCb.Location = new System.Drawing.Point(53, 62);
            this.tbMinCb.Maximum = 255;
            this.tbMinCb.Name = "tbMinCb";
            this.tbMinCb.Size = new System.Drawing.Size(85, 24);
            this.tbMinCb.TabIndex = 2;
            this.tbMinCb.Tag = "3";
            this.tbMinCb.Text = "metroTrackBar1";
            this.tbMinCb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Ycc_Scroll);
            // 
            // tbMaxCr
            // 
            this.tbMaxCr.BackColor = System.Drawing.Color.Transparent;
            this.tbMaxCr.Location = new System.Drawing.Point(254, 15);
            this.tbMaxCr.Maximum = 255;
            this.tbMaxCr.Name = "tbMaxCr";
            this.tbMaxCr.Size = new System.Drawing.Size(85, 24);
            this.tbMaxCr.TabIndex = 2;
            this.tbMaxCr.Tag = "2";
            this.tbMaxCr.Text = "metroTrackBar1";
            this.tbMaxCr.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Ycc_Scroll);
            // 
            // tbMinCr
            // 
            this.tbMinCr.BackColor = System.Drawing.Color.Transparent;
            this.tbMinCr.Location = new System.Drawing.Point(53, 15);
            this.tbMinCr.Maximum = 255;
            this.tbMinCr.Name = "tbMinCr";
            this.tbMinCr.Size = new System.Drawing.Size(85, 24);
            this.tbMinCr.TabIndex = 2;
            this.tbMinCr.Tag = "1";
            this.tbMinCr.Text = "metroTrackBar1";
            this.tbMinCr.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Ycc_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "We recommended you keep clear space behind \r\nto have great effect\r\n\r\n";
            // 
            // ucHandMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSettingInfo);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ucHandMovement";
            this.Size = new System.Drawing.Size(403, 554);
            ((System.ComponentModel.ISupportInitialize)(this.picSkinCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInputCam)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pnlSettingInfo.ResumeLayout(false);
            this.pnlSettingInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picSkinCam;
        private System.Windows.Forms.PictureBox picInputCam;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel pnlSettingInfo;
        private MetroFramework.Controls.MetroPanel pnlSetting;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar tbMaxCb;
        private MetroFramework.Controls.MetroTrackBar tbMinCb;
        private MetroFramework.Controls.MetroTrackBar tbMaxCr;
        private MetroFramework.Controls.MetroTrackBar tbMinCr;
        private MetroFramework.Controls.MetroLabel lblMaxCb;
        private MetroFramework.Controls.MetroLabel lblMaxCr;
        private MetroFramework.Controls.MetroLabel lblMinCb;
        private MetroFramework.Controls.MetroLabel lblMinCr;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblNumFinger;
        private MetroFramework.Controls.MetroLabel lblNote;
        private System.Windows.Forms.Label label1;
    }
}
