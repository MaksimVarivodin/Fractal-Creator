using IDZ.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDZ
{
    public partial class Form1 : Form
    {
        FrameService pictureBoxService;
        FrameService saveFrameService;
        
        void InitializePictureBoxService()
        {
            var pictureBox1Radius = pictureBox1.Width > pictureBox1.Height ? (double)pictureBox1.Height / 2.0 : (double)pictureBox1.Width / 2.0;
            pictureBoxService = new FrameService(
                new PointF((float)(pictureBox1.Width / 2.0), (float)(pictureBox1.Height / 2.0)),
                0,
                (int)verticesSelect.Value,
                (int)depthSelect.Value);            
            pictureBoxService.Width = pictureBox1.Width;
            pictureBoxService.Height = pictureBox1.Height;
            pictureBoxService.Angle = ((double)angleSelect.Value);
        }
        void InitializeSaveFrameService() {
            saveFrameService = new FrameService(
                new PointF((float)widthSelect.Value / 2.0f, (float)heightSelect.Value / 2.0f),
                (double)radiusSelect.Value* 0.9,
                (int)verticesSelect.Value,
                (int)depthSelect.Value
                );
            saveFrameService.Width =(int)widthSelect.Value; 
            saveFrameService.Height = (int)heightSelect.Value; 
            saveFrameService.Angle = ((double)angleSelect.Value);
        }
        public Form1()
        {
            InitializeComponent();            
            InitializePictureBoxService();
            radiusSelect.Value = (decimal)((double)(widthSelect.Value > heightSelect.Value ? heightSelect.Value / 2 : widthSelect.Value / 2) * 0.85);
        }
       

        // сохранение рисунка
        private void Save(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != null && saveFileDialog1.FileName.Length > 0)
                {
                    InitializeSaveFrameService();
                    gifService = new KochGifService(saveFrameService);
                    Bitmap img = saveFrameService.CreateFrame();
                    saveFrameService.SaveFrame(ref img, saveFileDialog1.FileName);
                }
            }
        }


        private void SetNewSize(object sender, EventArgs e)
        {
            pictureBoxService.Width = pictureBox1.Width;
            pictureBoxService.Height = pictureBox1.Height;
            pictureBoxService.Center = new PointF((float)(pictureBox1.Width / 2.0), (float)(pictureBox1.Height / 2.0));
            pictureBox1.Image = pictureBoxService.CreateFrame();            
        }

        private void ReDraw(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBoxService.CreateFrame();
        }

        private void RadiusChanged(object sender, EventArgs e)
        {
            pictureBoxService.Radius = (double)radiusSelect.Value;
        }

        private void VerticesChanged(object sender, EventArgs e)
        {
            pictureBoxService.Vertices = (int)verticesSelect.Value;
        }

        private void AngleChanged(object sender, EventArgs e)
        {
            pictureBoxService.Angle = ((double)angleSelect.Value);             
        }

        private void DepthChanged(object sender, EventArgs e)
        {
            pictureBoxService.KochDepth = (int)depthSelect.Value;
        }
    }
}
