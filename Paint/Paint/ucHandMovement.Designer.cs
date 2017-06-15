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
            this.picInputCam = new System.Windows.Forms.PictureBox();
            this.picSkinCam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInputCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinCam)).BeginInit();
            this.SuspendLayout();
            // 
            // picInputCam
            // 
            this.picInputCam.Location = new System.Drawing.Point(36, 35);
            this.picInputCam.Name = "picInputCam";
            this.picInputCam.Size = new System.Drawing.Size(405, 198);
            this.picInputCam.TabIndex = 0;
            this.picInputCam.TabStop = false;
            // 
            // picSkinCam
            // 
            this.picSkinCam.Location = new System.Drawing.Point(36, 250);
            this.picSkinCam.Name = "picSkinCam";
            this.picSkinCam.Size = new System.Drawing.Size(405, 216);
            this.picSkinCam.TabIndex = 0;
            this.picSkinCam.TabStop = false;
            // 
            // ucHandMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picSkinCam);
            this.Controls.Add(this.picInputCam);
            this.Name = "ucHandMovement";
            this.Size = new System.Drawing.Size(502, 518);
            ((System.ComponentModel.ISupportInitialize)(this.picInputCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picInputCam;
        private System.Windows.Forms.PictureBox picSkinCam;
    }
}
