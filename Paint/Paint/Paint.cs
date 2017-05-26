using MetroFramework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : MetroFramework.Forms.MetroForm
    {
        public Paint()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                MetroFramework.Controls.MetroTile _Tile = new MetroFramework.Controls.MetroTile();
                _Tile.Size = new Size(30, 30);
                _Tile.Tag = i;
                _Tile.Style = (MetroColorStyle)i;
                _Tile.Click += (sender, e) =>
                {
                    mtitleCurrentColor.UseCustomBackColor = false;
                    mtitleCurrentColor.Style = _Tile.Style;
                    mtitleCurrentColor.Refresh();
                };
                flColors.Controls.Add(_Tile);
            }
        }

        private void MLEditColor_Click(object sender, System.EventArgs e)
        {
            mtitleCurrentColor.UseCustomBackColor = true;
            ColorDialog EditColor = new ColorDialog();
            EditColor.ShowDialog();
            mtitleCurrentColor.BackColor = EditColor.Color;
        }
    }
}