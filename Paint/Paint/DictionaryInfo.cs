using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paint
{
    public partial class DictionaryInfo : MetroFramework.Forms.MetroForm
    {
        public DictionaryInfo()
        {
            InitializeComponent();
            
            string[] dictionary = File.ReadAllLines(@".\Grammar.txt");
            foreach (string i in dictionary)
            {
                listDicInfo.Items.Add(i);
            }          
        }

        private void llblOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
