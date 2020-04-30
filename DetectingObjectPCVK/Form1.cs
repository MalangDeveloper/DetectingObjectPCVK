using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.Drawing.Imaging;
using AForge;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;

namespace DetectingObjectPCVK
{
    public partial class Form1 : Form
    {
        FilterInfoCollection _device;
        VideoCaptureDevice _CaptureDevice;
        Bitmap _bitmapEdgeImage, _bitmapBinaryImage, _bitmapGreyImage, _bitmapBlurImage, _colorFilterImage;
        //ColorFiltering _colorFilter = new ColorFiltering();
        EuclideanColorFiltering _colorFilter = new EuclideanColorFiltering();
        System.Drawing.Font _font = new System.Drawing.Font("Times New Roman", 48, FontStyle.Bold);
        System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        SobelEdgeDetector _edgeFilter = new SobelEdgeDetector();
        Pen _PictureboxPen = new Pen(Color.Black, 5);

        bool _blurFlag = false;
        int ipenWidth = 5, iFeatureWidth;
        int iThreshold = 40, iRadius = 40;
        int iColorMode = 1, iRedValue = 220, iGreenValue = 30, iBlueValue = 30;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #region Form_Load, Closing
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _device = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                for (var i = 0; i < _device.Count; i++)
                    comboBox1.Items.Add(_device[i].Name);              
                                   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StopCameras();
            }
            catch
            {
                return;
            }
        }
        #endregion
             
        #region MyMethods
        private void SrartCameras(int deviceindex)
        {
            try
            {
                _CaptureDevice = new VideoCaptureDevice(_device[deviceindex].MonikerString);
                _CaptureDevice.NewFrame += new NewFrameEventHandler(get_Frame);
                //Start the Capture Device
                _CaptureDevice.Start();

                listBox1.Items.Add("Webcam connect");
                ScrollDown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopCameras()
        {
            try
            {
                _CaptureDevice.Stop();
            }
            catch (Exception)
            {
                return;
            }
        }

        void ScrollDown()
        {
            try
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void get_Frame(object sender, NewFrameEventArgs eventArgs)
        {
            //Insert image into Picuture Box
            Bitmap _BsourceFrame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = BlobDetection(_BsourceFrame);
            pictureBox2.Image = _bitmapEdgeImage;
            pictureBox3.Image = _bitmapBinaryImage;
            pictureBox4.Image = _colorFilterImage;        
        }

        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
            }

            return array;
        }

        private void sbRedColor_Scroll(object sender, ScrollEventArgs e)
        {
            iRedValue = sbRedColor.Value;

            listBox1.Items.Add("Red: " + iRedValue.ToString());
            ScrollDown();
        }

        #region Form_Load, Closing
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        #region MyMethods
        private void SrartCameras(int deviceindex)
        {

        }

        private void StopCameras()
        {

        }

        void ScrollDown()
        {

        }

        private void get_Frame(object sender, NewFrameEventArgs eventArgs)
        {

        }

        //private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        //{

        //}

        private void sbRedColor_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void sbBlueColor_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void sbGreenColor_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sbRadius_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sbThreshold_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private double FindDistance(int _pixel)
        {
            ///
            /// distance(D): distance of object from the camera
            /// _focalLength(F): focal length of camera
            /// _pixel(P): apparent width in pixel
            /// _ObjectWidth(W): width of object
            /// 
            /// F = (P*D)/W
            ///     -> D = (W*F)/P
            return _pixel;
        }
        #endregion

        #region Blob Detection
        /// <summary> Blob Detection    
        /// This method for color object detection by Blob counter algorithm.
        /// If you using this method, then you can detecting as follows:
        ///             red circle, rectangle, triangle
        ///             blue circle, rectangle, triangle
        ///             green circle, rectangle, triangle
        /// the process of this method as follow:
        ///     1. color filtering by Euclidean filtering(R, G, B).
        ///     2. the grayscale filtering based on color filtered image.
        ///     3. the binary filtering based on edge filter image.
        ///     4. Finally, detecting object, distance from the camera and degree are expreed on picturebox 1.
        /// </summary>

        //private Bitmap BlobDetection(Bitmap _bitmapSourceImage)
        //{
            
        //}
        #endregion
    }
}
