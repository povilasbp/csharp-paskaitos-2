using System;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using AForge.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_04_webcam
{


    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        public VideoCaptureDevice videoSource;
        public Bitmap bitmap;
        public AForge.Imaging.Filters.Invert invert_filtras = new AForge.Imaging.Filters.Invert();
        bool filtras = false;

        public Form1()
        {
            InitializeComponent();
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    throw new ApplicationException();
                }
                foreach (FilterInfo device in videoDevices)
                {
                    cameracombo.Items.Add(device.Name);
                }
            }
            catch (ApplicationException ex)
            {
                cameracombo.Items.Add("Nera lokaliu video irenginiu");
                videoDevices = null;
            }
        }

        private void video_NaujasFrame(object sender, NewFrameEventArgs eventargs)
        {
            bitmap = (Bitmap)eventargs.Frame.Clone();

            this.Invoke((MethodInvoker)delegate
            {
                if(filtras)
                {
                    invert_filtras.ApplyInPlace(bitmap);
                }
                pictureBox1.Image = bitmap;
                pictureBox1.Refresh();
            });
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[cameracombo.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NaujasFrame);
            videoSource.Start();
        }

        private void checkFiltras_CheckedChanged(object sender, EventArgs e)
        {
            if(filtras)
            {
                filtras = false;
            }
            else
            {
                filtras = true;
            }
        }
    }
}
