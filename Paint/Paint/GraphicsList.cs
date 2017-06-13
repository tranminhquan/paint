using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Paint
{
    class GraphicsList
    {
        #region Decalre
        public List<ObjectDrawing> _list;
        public int _posINCOMPLETE;
        #endregion

        #region Method
        public GraphicsList()
        {
            _list = new List<ObjectDrawing>();
        }

        public void Draw(Graphics g)
        {

            for (int i = 0; i < _list.Count; i++)
            {
                if (i == _posINCOMPLETE && _list[i]._startPoint != _list[i]._endPoint )
                    _list[i].DrawHandlePoint(g);
                _list[i].Draw(g);
            }
        }

     
        public void RemoveLast()
        {
            try
            {
                _list.RemoveAt(_list.Count - 1);
            }
            catch
            {
                MessageBox.Show("System error (GraphicsList cant find any element", "Noice");
            }
        }
        #endregion
    }
}
