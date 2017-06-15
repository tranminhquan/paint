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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInputCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinCam)).BeginInit();
            this.SuspendLayout();
            // 
            // picInputCam
            // 
            this.picInputCam.Location = new System.Drawing.Point(36, 35);
            this.picInputCam.Name = "picInputCam";
            this.picInputCam.Size = new System.Drawing.Size(405, 198);
            this.picInputCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInputCam.TabIndex = 0;
            this.picInputCam.TabStop = false;
            // 
            // picSkinCam
            // 
            this.picSkinCam.Location = new System.Drawing.Point(36, 250);
            this.picSkinCam.Name = "picSkinCam";
            this.picSkinCam.Size = new System.Drawing.Size(405, 216);
            this.picSkinCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkinCam.TabIndex = 0;
            this.picSkinCam.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucHandMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}
