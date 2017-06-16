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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInputCam)).BeginInit();
            this.metroPanel1.SuspendLayout();
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
            this.btnStart.Location = new System.Drawing.Point(110, 350);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(169, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnStart);
            this.metroPanel1.Controls.Add(this.picInputCam);
            this.metroPanel1.Controls.Add(this.picSkinCam);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(398, 407);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 407);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(398, 128);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // ucHandMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ucHandMovement";
            this.Size = new System.Drawing.Size(398, 549);
            ((System.ComponentModel.ISupportInitialize)(this.picSkinCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInputCam)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picSkinCam;
        private System.Windows.Forms.PictureBox picInputCam;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}
