using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
//using Emgu.CV.UI
namespace Paint
{
    public partial class ucHandMovement : MetroFramework.Controls.MetroUserControl
    {
        Capture capture;
        Image<Bgr, byte> currentFrame;
        bool captureInProgress;
        public ucHandMovement()
        {
            if (!this.DesignMode)
            {
                this.InitializeComponent();
                #region
                if (capture == null)
                {
                    try
                    {
                        capture = new Capture();
                        capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, 5);

                    }
                    catch (NullReferenceException excpt)
                    {
                        MessageBox.Show(excpt.Message);
                    }
                }
                #endregion

                if (capture != null)
                {
                    if (captureInProgress)
                    {                   
                        Application.Idle += ProcessFramAndUpdateGUI;
                    }
                    else
                    {             
                        Application.Idle -= ProcessFramAndUpdateGUI;
                    }
                    captureInProgress = !captureInProgress;
                }
            }
        }

        void ProcessFramAndUpdateGUI(object Sender, EventArgs agr)
        {
            int Finger_num = 0;
            Double Result1 = 0;
            Double Result2 = 0;
            //querying image
            currentFrame = capture.QueryFrame().ToImage<Bgr, byte>();
            if (currentFrame == null) return;



            //Applying YCrCb filter
            Image<Ycc, Byte> currentYCrCbFrame = currentFrame.Convert<Ycc, byte>();
            Image<Gray, byte> skin = new Image<Gray, byte>(currentFrame.Width, currentFrame.Height);

            skin = currentYCrCbFrame.InRange(new Ycc(0, 131, 80), new Ycc(255, 185, 135));

            //Erode
            Mat rect_12 = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(10, 10), new Point(5, 5));
            CvInvoke.Erode(skin, skin, rect_12, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());

            //Dilate
            Mat rect_6 = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(6, 6), new Point(3, 3));
            CvInvoke.Dilate(skin, skin, rect_6, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());


            skin = skin.Flip(FlipType.Horizontal);

            //smoothing the filterd , eroded and dilated image.
            skin = skin.SmoothGaussian(9);

            currentFrame = currentFrame.Flip(FlipType.Horizontal);

            picInputCam.Image = currentFrame.ToBitmap();
            picSkinCam.Image = skin.ToBitmap();
        }
    }
}
