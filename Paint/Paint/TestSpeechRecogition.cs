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
    public partial class TestSpeechRecogition : Form
    {
       
        SpeechRecognition SpeechReg = new SpeechRecognition();
        private string temp;
        public TestSpeechRecogition()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            SpeechReg.Start();
            SpeechReg._sender = new SpeechRecognition.SEND(GetString);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            SpeechReg.Stop();
        }

        private void TestSpeechRecogition_Load(object sender, EventArgs e)
        {
           
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
         
        }

        public void GetString(string s)
        {
           temp = s;
            SetText(temp);
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
          
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.txtResult.Invoke(d, text);
            }
            else
            {
                this.txtResult.Text = text;
            }        
        }
    }
}
