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
        #region Declare
        // thong tin cua anh can fill
        Bitmap _pic;
        Bitmap _fillpic;
        int x;
        int y;
        #endregion

        #region Method

        public BucketDrawing(Bitmap _pic, Bitmap _fillpic, int x, int y,Color _color)
        {
            this._pic = _pic;
            this._fillpic = _fillpic;
            this.x = x;
            this.y = y;
            this._color = _color;
        }

        public override Point getMouseClick() 
        {
            return new Point(x, y);
        }
        #endregion

        #region Event

        public override void Mouse_Down(MouseEventArgs e)
        {

        }
        #endregion

        #region Function
        public Bitmap Fill()
        {
            PointedColorFloodFill bucket = new PointedColorFloodFill();
            _fillpic = _pic.Clone(new Rectangle(0, 0, _pic.Width, _pic.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bucket.FillColor = _color;
            bucket.Tolerance = _pic.GetPixel(x,y);
            bucket.StartingPoint = new IntPoint(x,y);
            return bucket.Apply(_fillpic);
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(Fill(), new Point(0, 0));
        }

        #endregion
    }
}
