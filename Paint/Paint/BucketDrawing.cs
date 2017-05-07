using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using AForge;
using AForge.Imaging.Filters;

namespace Paint
{
    class BucketDrawing : ObjectDrawing
    {
        #region Method

        public BucketDrawing(Color _color)
        {
            this._color = _color;
        }

        #endregion

        #region Event

        public override void Mouse_Down(MouseEventArgs e)
        {

        }
        #endregion

        #region Function
        public Bitmap Fill(Bitmap _pic, Bitmap _fillpic, int x, int y)
        // clickColor la color o vi tri click
        {
            PointedColorFloodFill bucket = new PointedColorFloodFill();
            _fillpic = _pic.Clone(new Rectangle(0, 0, _pic.Width, _pic.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bucket.FillColor = _color;
            bucket.Tolerance = _pic.GetPixel(x,y );
            bucket.StartingPoint = new IntPoint(x,y);
            return bucket.Apply(_fillpic);
        }


        #endregion
    }
}
