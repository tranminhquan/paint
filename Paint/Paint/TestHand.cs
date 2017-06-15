using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class TestHand : MetroFramework.Forms.MetroForm
    {
        public TestHand()
        {
            InitializeComponent();
            ucHandMovement handMove = new ucHandMovement();
            handMove.Parent = this;
        }
    }
}
