namespace Paint
{
    partial class DictionaryInfo
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.llblOk = new MetroFramework.Controls.MetroLink();
            this.listDicInfo = new MetroFramework.Controls.MetroListView();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(20, 370);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(503, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "I can help you to do some basic functions, choose shapes, tools, color and so on";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // llblOk
            // 
            this.llblOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.llblOk.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.llblOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.llblOk.Location = new System.Drawing.Point(20, 392);
            this.llblOk.Name = "llblOk";
            this.llblOk.Size = new System.Drawing.Size(697, 28);
            this.llblOk.TabIndex = 7;
            this.llblOk.Text = "Got it!\r\n";
            this.llblOk.UseCustomBackColor = true;
            this.llblOk.UseCustomForeColor = true;
            this.llblOk.UseSelectable = true;
            this.llblOk.Click += new System.EventHandler(this.llblOk_Click);
            // 
            // listDicInfo
            // 
            this.listDicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(247)))));
            this.listDicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.listDicInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listDicInfo.ForeColor = System.Drawing.Color.Black;
            this.listDicInfo.FullRowSelect = true;
            this.listDicInfo.HideSelection = false;
            this.listDicInfo.Location = new System.Drawing.Point(20, 168);
            this.listDicInfo.Name = "listDicInfo";
            this.listDicInfo.OwnerDraw = true;
            this.listDicInfo.Scrollable = false;
            this.listDicInfo.Size = new System.Drawing.Size(697, 202);
            this.listDicInfo.TabIndex = 6;
            this.listDicInfo.UseCompatibleStateImageBehavior = false;
            this.listDicInfo.UseCustomBackColor = true;
            this.listDicInfo.UseCustomForeColor = true;
            this.listDicInfo.UseSelectable = true;
            this.listDicInfo.View = System.Windows.Forms.View.List;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(99)))));
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.Location = new System.Drawing.Point(20, 60);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(697, 108);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = ">>  \r\nThose are how much I can help you";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // DictionaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 440);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.llblOk);
            this.Controls.Add(this.listDicInfo);
            this.Controls.Add(this.metroTile1);
            this.Name = "DictionaryInfo";
            this.Text = "Dictionary Information";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink llblOk;
        private MetroFramework.Controls.MetroListView listDicInfo;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}