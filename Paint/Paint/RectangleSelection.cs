using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class RectangleSelection : RectangleDrawing
    {
        #region Declare
        public Image _img;
        #endregion

        #region Method
        public RectangleSelection() : base()
        {
        }
        public RectangleSelection(Color color, int penwidth) : base(color, penwidth)
        {
        }
        public override void Draw(Graphics g)
        {
            if (isSelectDone == false)
            {
                Pen p = new Pen(Color.Black, 1);
                float[] dashValues = { 2, 2, 2, 2 };

                p.DashPattern = dashValues;
                g.DrawRectangle(p, GetRectangle(_startPoint, _endPoint));
            }
            if (_img != null)
            {
                g.DrawImage(_img, GetRectangle(new Point(_startPoint.X +1, _startPoint.Y + 1), new Point(_endPoint.X,_endPoint.Y )));
            }
     
        }
        public override int CheckLocation(Point cursor)
        {
            for (int i = 1; i <= HANDLE_COUNT; i++)
            {
                if (GetRectangleHandle(i).Contains(cursor))
                    return i;
            }

            //Neu con tro thuoc region
            if (_region.IsVisible(cursor))
                return 0;

            //Neu con tro nam ngoai region
            return -1;
        }
        public override void ChangeSize(int handleIndex, Point destiny)
        {
            base.ChangeSize(handleIndex, destiny);
        }
        public override void ChangeStartAndEndPoint(int handleIndex)
        {
            base.ChangeStartAndEndPoint(handleIndex);
        }

        // Copy the selected area to the clipboard.
        public void CopyToClipboard(Rectangle src_rect, Image originalImage)
        {
            // Make a bitmap for the selected area's image.
            Bitmap bm = new Bitmap(src_rect.Width, src_rect.Height);

            // Copy the selected area into the bitmap.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                Rectangle dest_rect = new Rectangle(0, 0, src_rect.Width, src_rect.Height);
                gr.DrawImage(originalImage, dest_rect, src_rect, GraphicsUnit.Pixel);
            }

            // Copy the selection image to the clipboard.
            Clipboard.SetImage(bm);
        }
       
        #endregion

        #region Event
        public override void Mouse_Up(MouseEventArgs e)
        {
            base.Mouse_Up(e);

        }
        public override void Mouse_Move(MouseEventArgs e)
        {
            base.Mouse_Move(e);
        }
        public override void Mouse_Down(MouseEventArgs e)
        {
            base.Mouse_Down(e);
        }
        #endregion
    }

}
