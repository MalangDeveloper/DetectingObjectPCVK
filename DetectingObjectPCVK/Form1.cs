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
        public Form1()
        {
            InitializeComponent();
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
