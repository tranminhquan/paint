using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Paint
{
    public partial class Paint : MetroFramework.Forms.MetroForm
    {
        #region Declare
        enum DRAW_STATUS { COMPLETE, INCOMPLETE };
        int penWidth = 1;
        string objectChoose;
        ObjectDrawing Shape;
        Bitmap doubleBuffer, fillImage;
        GraphicsList grapList;
        DRAW_STATUS status;
        bool isSaved = true;
        Graphics pen; // pen width
        bool isCrop = false;
        bool isCropRectDraw = false;
        int posOfCrop;
        SpeechRecognition speechReg;
        #endregion

        // danh sách màu mặc định
        List<Color> listColor = new List<Color>() { Color.Black , Color.Black , Color.White , Color.Silver , Color.Blue , Color.Green , Color.Lime , Color.Teal ,Color.Orange
                                                    , Color.Brown , Color.Pink , Color.Magenta , Color.Purple , Color.Red , Color.Yellow };
        public Paint()
        {
            InitializeComponent();
            
               
            for (int i = 1; i < 14; i++)
            {
                MetroFramework.Controls.MetroTile _Tile = new MetroFramework.Controls.MetroTile();
                _Tile.Size = new Size(30, 30);
                _Tile.Tag = i;
                _Tile.UseCustomBackColor = true;
                _Tile.BackColor = listColor[i];
                //_Tile.Style = (MetroColorStyle)i;
                _Tile.Click += (sender, e) =>
                {
                    
                    mtitleCurrentColor.UseCustomBackColor = true;
                    mtitleCurrentColor.BackColor = _Tile.BackColor;

                    mtitleCurrentColor.Refresh();
                };
                flColors.Controls.Add(_Tile);
            }
            mtitleCurrentColor.BackColor = Color.Blue;
            doubleBuffer = new Bitmap(Screen.PrimaryScreen.Bounds.Width - 300, Screen.PrimaryScreen.Bounds.Height, picPaint.CreateGraphics());
            Graphics g = Graphics.FromImage(doubleBuffer);
            g.Clear(Color.White);
            fillImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width - 300, Screen.PrimaryScreen.Bounds.Height, picPaint.CreateGraphics());
            g = Graphics.FromImage(fillImage);
            g.Clear(Color.White);
            grapList = new GraphicsList();

            pen = pn_penWidth.CreateGraphics();

            status = DRAW_STATUS.COMPLETE;
            #region Set for recognizer
            speechReg = new SpeechRecognition();
            #endregion
        }
        private Color ChooseColor(int index)
        {
            return listColor[index];
        }
        private void MLEditColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog EditColor = new ColorDialog();
            EditColor.ShowDialog();
            mtitleCurrentColor.BackColor = EditColor.Color;
        }

        private void picPaint_Paint(object sender, PaintEventArgs e)
        {
            
            doubleBuffer = fillImage.Clone(new Rectangle(0, 0, fillImage.Width, fillImage.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(doubleBuffer);
            if (grapList._list.Count > 0)
            {
                btnUndo.Enabled = true;
                grapList.Draw(g);
            }
            else
            {
                btnUndo.Enabled = false;
            }
            if ((status == DRAW_STATUS.INCOMPLETE && objectChoose != "bucket" && objectChoose != "none" && objectChoose!=null) && (Shape._startPoint != Shape._endPoint && Shape!=null))
                Shape.DrawHandlePoint(g);
            e.Graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
           
        }

        private void picPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isSaved = false;
            if (e.Button == MouseButtons.Left)
            {

                //Neu da chon doi tuong
                if (objectChoose == "bucket")
                {
                    //Shape = null;    
                    Shape = new BucketDrawing(doubleBuffer, fillImage, e.X, e.Y,mtitleCurrentColor.BackColor);

                    grapList._list.Insert(grapList._list.Count, Shape);

                    picPaint.Refresh();
                }
                else if (objectChoose == "rectangle" || objectChoose == "circle" || objectChoose == "star" || 
                    objectChoose == "line" || objectChoose == "rhombus" || objectChoose == "triangle" || 
                    objectChoose == "pentagon" || objectChoose == "hexagon" || objectChoose == "crop")
                {

                    if (Shape != null && Shape.CheckLocation(e.Location) >= 0)
                    {
                        Shape.Mouse_Down(e);
                        status = DRAW_STATUS.INCOMPLETE;

                        if (Shape.CheckLocation(e.Location) == 0)
                            Cursor = Cursors.SizeAll;
                        if (Shape.CheckLocation(e.Location) > 0)
                            Cursor = Cursors.Cross;
                    }

                    else
                    {
                        if (objectChoose != "crop")
                        {
                            
                            status = DRAW_STATUS.COMPLETE;
                            ChooseObject();
                            Shape.Mouse_Down(e);

                            grapList._list.Insert(grapList._list.Count, Shape);
                            if (isCropRectDraw == true)
                            {
                                grapList._list.RemoveAt(posOfCrop);
                            }

                        }
                        else
                        {
                            isCropRectDraw = true;
                            if (isCrop == true)
                            {
                                if (grapList._list.Count != 0)
                                    grapList._list.RemoveAt(grapList._list.Count - 1);
                                picPaint.Refresh();
                            }

                            status = DRAW_STATUS.COMPLETE;
                            ChooseObject();
                            Shape.Mouse_Down(e);
                            grapList._list.Insert(grapList._list.Count, Shape);

                        }
                    }

                }
                else
                {
                    status = DRAW_STATUS.COMPLETE;
                    ChooseObject();
                    Shape.Mouse_Down(e);
                    grapList._list.Insert(grapList._list.Count, Shape);                  
                }
            }

            else
            {
                status = DRAW_STATUS.COMPLETE;
                Shape = null;
            }
            picPaint.Refresh();
        }
        private void picPaint_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = e.Location.X + " x " + e.Location.Y;        
            if (Shape != null)
            {
                Shape.Mouse_Move(e);
                status = DRAW_STATUS.INCOMPLETE;
                if (Shape.CheckLocation(e.Location) == 0)
                    Cursor = Cursors.SizeAll;
                else if (Shape.CheckLocation(e.Location) > 0)
                    Cursor = Cursors.Cross;
                else
                    Cursor = Cursors.Default;
                picPaint.Refresh();
            }

        }

        private void picPaint_MouseUp(object sender, MouseEventArgs e)
        {
            if (objectChoose == "pencil" || objectChoose == "eraser")
            {
                Shape = null;                
                status = DRAW_STATUS.COMPLETE;
            }
            if (Shape != null)

                Shape.Mouse_Up(e);
        }

        private void TB_penWidth_Scroll(object sender, ScrollEventArgs e)
        {
            penWidth = tbPenWidth.Value;
            //lb_penWidth.Text = TB_penWidth.Value.ToString();
            DrawpenWidth();
        }
        public void btnObject_Click(object sender, EventArgs e)
        {

            Button btnObject = (Button)sender;
            objectChoose = btnObject.Name.Remove(0, 3).ToLower();
            if (objectChoose != "crop")
            {
                isCrop = false;
            }

            if (objectChoose == "crop" && isCrop == true)
            {
                status = DRAW_STATUS.COMPLETE;

                int width = Math.Abs(Shape._endPoint.X - Shape._startPoint.X);
                int height = Math.Abs(Shape._endPoint.Y - Shape._startPoint.Y);
                Rectangle ROI = new Rectangle(Shape._startPoint.X + 1, Shape._startPoint.Y + 1, width - 2, height - 2);

                fillImage = CropImage(doubleBuffer, ROI);

                panelPaint.Dock = DockStyle.None;
                panelPaint.Size = fillImage.Size;

                picPaint.Refresh();
                isCrop = false;
            }
          
            //if (objectChoose == "pencil")
            //    picPaint.Cursor = new Cursor(Application.StartupPath + "\\Pencil -v.cur");
            //else if (objectChoose == "eraser")
            //    picPaint.Cursor = new Cursor(Application.StartupPath + "\\Eraser.cur");
            //else if (objectChoose == "bucket")
            //    picPaint.Cursor = new Cursor(Application.StartupPath + "\\bucket.cur");
            
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            this.Undo();
        }

        private Bitmap CropImage(Bitmap src, Rectangle Roi)
        {
            Bitmap croppedImg;
            croppedImg = src.Clone(Roi, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            return croppedImg;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.New();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Open();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            this.SaveAs();
        }
        private void Paint_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isSaved == false)
            {
                DialogResult dlr = MessageBox.Show("Do you want to save first?", "Absoluke Paint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    btnSaveAs_Click(sender, e);
                    isSaved = true;
                    this.Dispose();
                }
                else
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            };
        }

        private void ChooseObject()
        {
            switch (objectChoose)
            {
                case "pencil":
                    Shape = new PenDrawing(mtitleCurrentColor.BackColor, penWidth);
                    
                    break;
                case "eraser":
                    Shape = new EraserDrawing(penWidth);
                    break;
                case "rectangle":
                    Shape = new RectangleDrawing(mtitleCurrentColor.BackColor, penWidth);
                    break;
                case "circle":
                    Shape = new CircleDrawing(mtitleCurrentColor.BackColor, penWidth);
                    break;
                case "star":
                    Shape = new StarDrawing(mtitleCurrentColor.BackColor, penWidth);
                    break;
                case "line":
                    Shape = new LineDrawing(mtitleCurrentColor.BackColor, penWidth);
                    break;
                case "triangle":
                    Shape = new TriangleDrawing(mtitleCurrentColor.BackColor, penWidth);
                    break;
                case "rhombus":
                    Shape = new RhombusDrawing(mtitleCurrentColor.BackColor, penWidth);
                    break;
                case "pentagon":
                    Shape = new PentagonDrawing(mtitleCurrentColor.BackColor, penWidth);
                    break;
                case "hexagon":
                    Shape = new HexagonDrawing(mtitleCurrentColor.BackColor, penWidth);
                    break;
                case "crop":
                    {
                        Shape = new CropRectangle();
                        isCrop = true;
                        posOfCrop = grapList._list.Count;
                    }
                    break;

                default:
                    objectChoose = "none";
                    Shape = new NoneShapeDrawing();
                    break;
            }
        }

        private void pn_penWidth_Paint(object sender, PaintEventArgs e)
        {
            DrawpenWidth();
            
        }

        private void llbAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A gift to Vuong-sama");
        }
        public void DrawpenWidth()
        {
            pen.Clear(Color.FromArgb(128, 128, 255));
            SolidBrush brush = new SolidBrush(mtitleCurrentColor.BackColor);
            RectangleF rec = new RectangleF(2, 2, pn_penWidth.Width, pn_penWidth.Height);
            pen.DrawLine(new Pen(mtitleCurrentColor.BackColor, penWidth), new Point(5, pn_penWidth.Height / 2), new Point(pn_penWidth.Width - 5, pn_penWidth.Height / 2));
        }
        #region BasicFunctions
        private void New()
        {
            //Shape = null;
            grapList._list.Clear();
            if (isSaved == false)
            {
                DialogResult dlr = MessageBox.Show("Do you want to save first?", "Absoluke Paint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    this.SaveAs();
                    isSaved = true;
                    //panelPaint.Size = new Size(1145, 737);
                    fillImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width - 300, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    Graphics g = Graphics.FromImage(fillImage);
                    g.Clear(Color.White);
                    picPaint.Size = fillImage.Size;
                    picPaint.Refresh();
                    isSaved = true;
                }
                else
                {
                    //panelPaint.Size = new Size(1145, 737);
                    fillImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width - 300, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    Graphics g = Graphics.FromImage(fillImage);
                    g.Clear(Color.White);
                    picPaint.Size = fillImage.Size;
                    picPaint.Refresh();
                    isSaved = true;
                }
            }
            else
            {
                //panelPaint.Size = new Size(1145, 737);
                fillImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width - 300, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(fillImage);
                g.Clear(Color.White);
                picPaint.Size = fillImage.Size;
                picPaint.Refresh();
            }
            panelPaint.Dock = DockStyle.Fill;
        }
        private void SaveAs()
        {
            if (File.Exists(saveFileDialog1.FileName))
                doubleBuffer.Save(saveFileDialog1.FileName);
            else
            {
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.Filter = "BMP (*.bmp)|*.bmp|All File (*.*)|*.*";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.OverwritePrompt = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    doubleBuffer.Save(saveFileDialog1.FileName);
                isSaved = true;
            }
        }
        private void Open()
        {
            openFileDialog1.Filter = "All Picture Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                            "Windows Bitmap (*.bmp)|*.bmp|" +
                            "All Files (*.*)|*.*";
            openFileDialog1.Title = "Open an Image File";

            this.New();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fillImage = new Bitmap(openFileDialog1.FileName);
                    picPaint.Image = fillImage;
                    picPaint.Refresh();
                }
                catch
                {
                    MessageBox.Show("Can't read this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void Undo()
        {
            status = DRAW_STATUS.COMPLETE;
            grapList.RemoveLast();
            picPaint.Refresh();
           
        }

        private void Exit()
        {
            DialogResult rslt = MessageBox.Show("Do you want to exit Absoluke Paint?", "Confirm", MessageBoxButtons.YesNo);
            if (rslt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Hot keys for form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                this.New();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                this.Open();
                return true;
            }
            if (keyData == (Keys.Control | Keys.O))
            {
                this.SaveAs();
                return true;
            }
            if (keyData == (Keys.Control | Keys.Z))
            {
                this.Undo();
                return true;
            }
            if (keyData == (Keys.Control | Keys.P))
            {
                objectChoose = "pencil";
                picPaint.Cursor = new Cursor(Application.StartupPath + "\\Pencil -v.cur");
                return true;
            }
            if (keyData == (Keys.Control | Keys.E))
            {
                objectChoose = "eraser";
                picPaint.Cursor = new Cursor(Application.StartupPath + "\\Eraser.cur");
                return true;
            }
            if (keyData == (Keys.Control | Keys.F))
            {
                objectChoose = "bucket";
                picPaint.Cursor = new Cursor(Application.StartupPath + "\\bucket.cur");
                return true;
            }
            if (keyData == (Keys.F1))
            {
                if (tgSpeechRecog.Checked)
                    tgSpeechRecog.Checked = false;
                else
                    tgSpeechRecog.Checked = true;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Methods RECOGNITION
        private void tgSpeechRecog_CheckedChanged(object sender, EventArgs e)
        {
            if (tgSpeechRecog.Checked)
            {
                pnlReconizer.Visible = true;
                speechReg.Start();
                speechReg._sender = new SpeechRecognition.SEND(GetString);
            }
            else
            {
                pnlReconizer.Visible = false;
                speechReg.Stop();
            }
           
        }

        public void GetString(string s)
        {
            SetText(s);

            //Xu ly cac lenh tai day
            switch(s)
            {
                //Basic functions:
                case "new":
                    this.New();
                    break;
                case "open":
                    this.Open();
                    break;
                case "save":
                    this.SaveAs();
                    break;

                //Tool:
                case "pencil":
                    objectChoose = "pencil";
                    break;
                case "eraser":
                    objectChoose = "eraser";
                    break;
                case "undo":
                    this.Undo();
                    break;            
                case "theme":
                    tabOptions.SelectedIndex = 0;
                    break;
                case "tool":
                    tabOptions.SelectedIndex = 1;
                    break;                   
                case "shape":
                    tabOptions.SelectedIndex = 2;
                    break;
                //Shape:
                case "rectangle":
                    objectChoose = "rectangle";
                    break;
                case "circle":
                    objectChoose = "circle";
                    break;
                case "star":
                    objectChoose = "star";
                    break;
                case "line":
                    objectChoose = "line";
                    break;
                case "triangle":
                    objectChoose = "triangle";
                    break;
                case "rhombus":
                    objectChoose = "rhombus";
                    break;
                case "pentagon":
                    objectChoose = "pentagon";
                    break;               
                case "hexagon":
                    objectChoose = "hexagon";
                    break;
                //bucket
                case "paint":
                    objectChoose = "bucket";
                    break;
                //color
                case "red":   
                                   
                case "green":
                   
                case "blue":
                   
                case "yellow":
                 
                case "orange":
                    
                case "black":
                   
                case "white":
                   
                case "gray":
                    mtitleCurrentColor.BackColor = Color.FromName(s);
                    break;
                //Turn off and exit
                case "turn off":
                case "stop":
                    tgSpeechRecog.Checked = false;
                    break;
                
                case "exit":
                case "close":
                    this.Exit();
                    break;
                default:
                    {
                        string size = s.Remove(s.Length - 2, 2);
                        if (size == "size")
                        {
                            int index = int.Parse(s.Remove(0, 5));
                            tbPenWidth.Value = index;
                            penWidth = tbPenWidth.Value;                            
                            DrawpenWidth();
                        }
                        break;
                    }       
            }
        }

        delegate void SetTextCallback(string text);

        private void llblDicInfo_Click(object sender, EventArgs e)
        {
            DictionaryInfo ucDicInfo = new DictionaryInfo();
            ucDicInfo.ShowDialog();
        }

        private void tbConfidence_Scroll(object sender, ScrollEventArgs e)
        {
            speechReg.Confindence = ((float)tbConfidence.Value / 10);
            lblConfidence.Text = speechReg.Confindence.ToString();
        }

        private void pnlSetting_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbConfidence.Visible == false)
            {
                tbConfidence.Value = (int) (speechReg.Confindence * 10);
                tbConfidence.Visible = true;
                lblNoise.Visible = true;
                lblQuiet.Visible = true;
                lblConfidence.Text = speechReg.Confindence.ToString();
                lblConfidence.Visible = true;
            }
            else
            {
                tbConfidence.Visible = false;
                lblNoise.Visible = false;
                lblQuiet.Visible = false;          
                lblConfidence.Visible = false;
            }
        }

        private void SetText(string text)
        {

            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblSpeechResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.lblSpeechResult.Invoke(d, text);
            }
            else
            {
                this.lblSpeechResult.Text = text;
            }
        }
        #endregion
    }
}