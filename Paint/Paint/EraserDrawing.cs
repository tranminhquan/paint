using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class EraserDrawing : PenDrawing
    {
        #region Declare
        #endregion

        #region Method
        public EraserDrawing()
        {
            _color = Color.White;
            _penWidth = 2;
        }

        public EraserDrawing(int penWidth)
        {
            _color = Color.White;
            _penWidth = penWidth;
        }
        #endregion

        #region Event
        #endregion
    }
}
