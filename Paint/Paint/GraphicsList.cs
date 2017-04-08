using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Paint
{
    class GraphicsList
    {
        #region Decalre
        public List<ObjectDrawing> _list;
        #endregion

        #region Method
        public GraphicsList()
        {
            _list = new List<ObjectDrawing>();
        }

        public void Draw(Graphics g)
        {
            foreach(ObjectDrawing ObjDrawing in _list)
            {
                ObjDrawing.Draw(g);
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
