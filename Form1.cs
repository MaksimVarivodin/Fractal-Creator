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
using static System.Net.Mime.MediaTypeNames;

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
            innerColor.Image = ColorFillerService.CreateFilledRectangle(pictureBoxService.LineColor, innerColor.Width, innerColor.Height);
            kochColor.Image = ColorFillerService.CreateFilledRectangle(pictureBoxService.KochColor, kochColor.Width, kochColor.Height); ;
            backgroundColor.Image = ColorFillerService.CreateFilledRectangle(pictureBoxService.BackFill, backgroundColor.Width, backgroundColor.Height);
            double dpiWidth = (double)(pictureBox1.Width)/(double)(((int)widthSelect.Value));
            double dpiHeight = (double)(pictureBox1.Height) / (double)(((int)heightSelect.Value));
            pictureBoxService.MoveTo(new PointF((float)xCoordinate.Value*(float)dpiWidth, (float)yCoordinate.Value* (float)dpiHeight));
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

            saveFrameService.LineColor = pictureBoxService.LineColor;
            
            saveFrameService.KochColor = pictureBoxService.KochColor;
             
            saveFrameService.BackFill = pictureBoxService.BackFill;
            pictureBoxService.Move(((float)xCoordinate.Value), ((float)yCoordinate.Value));
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
                    Bitmap img = saveFrameService.CreateFrame();
                    saveFrameService.SaveFrame(ref img, saveFileDialog1.FileName);
                }
            }
        }


        private void SetNewSize(object sender, EventArgs e)
        {
            int differenceWidth = (pictureBox1.Width- pictureBoxService.Width)/2;
            int differenceHeight = (pictureBox1.Height - pictureBoxService.Height) / 2;
            pictureBoxService.Width = pictureBox1.Width;
            pictureBoxService.Height = pictureBox1.Height;
            //pictureBoxService.Center = new PointF(pictureBoxService.Center.X+ differenceWidth, pictureBoxService.Center.Y+ differenceHeight);
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

        private void LineWidthChanged(object sender, EventArgs e)
        {
            pictureBoxService.LineWidth = ((int)lineSelect.Value);
        }

        private void KochWidthChanged(object sender, EventArgs e)
        {
            pictureBoxService.KochWidth = ((int)kochSelect.Value);
        }
        private Color? FillFromDialog() {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                return colorDialog1.Color;
            else return null;
        }
        private void SetInnerColor(object sender, EventArgs e)
        {
            Color? color = FillFromDialog();
            if (color.HasValue)
            {
                pictureBoxService.LineColor = color.Value;
                innerColor.Image = ColorFillerService.CreateFilledRectangle(color.Value, innerColor.Width, innerColor.Height);                
            }            
            
        }

        private void SetKochColor(object sender, EventArgs e)
        {
  
            Color? color = FillFromDialog();
            if (color.HasValue)
            {
                pictureBoxService.KochColor = color.Value;
                kochColor.Image = ColorFillerService.CreateFilledRectangle(color.Value, kochColor.Width, kochColor.Height);
            }
        }

        private void SetBackGroundColor(object sender, EventArgs e)
        {
            Color? color = FillFromDialog();
            if (color.HasValue)
            {
                pictureBoxService.BackFill = color.Value;
                backgroundColor.Image = ColorFillerService.CreateFilledRectangle(color.Value, backgroundColor.Width, backgroundColor.Height);
            }
        }

        private void SetInnerAlfa(object sender, EventArgs e)
        {
            TransparencyDialog dialog = new TransparencyDialog(pictureBoxService.LineColor, pictureBoxService.LineColor.A);
            Point buttonAbsLoc = innerAlfaButton.PointToScreen(Point.Empty);
            Point buttonLocalLoc = innerAlfaButton.PointToClient(Point.Empty);
            
            dialog.Location = new Point(buttonAbsLoc.X, buttonAbsLoc.Y - dialog.Height);
            dialog.ShowDialog();
            pictureBoxService.LineColor = dialog.NewAlfa;
            innerColor.Image = ColorFillerService.CreateFilledRectangle(dialog.NewAlfa, innerColor.Width, innerColor.Height);
        }

        private void SetKochAlfa(object sender, EventArgs e)
        {
            TransparencyDialog dialog = new TransparencyDialog(pictureBoxService.KochColor, pictureBoxService.KochColor.A);
            dialog.ShowDialog();
            pictureBoxService.KochColor = dialog.NewAlfa;
            kochColor.Image = ColorFillerService.CreateFilledRectangle(dialog.NewAlfa, kochColor.Width, kochColor.Height);
        }

        private void SetBackGoundAlfa(object sender, EventArgs e)
        {
            TransparencyDialog dialog = new TransparencyDialog(pictureBoxService.BackFill, pictureBoxService.BackFill.A);
            dialog.ShowDialog();
            pictureBoxService.BackFill = dialog.NewAlfa;
            backgroundColor.Image = ColorFillerService.CreateFilledRectangle(dialog.NewAlfa, backgroundColor.Width, backgroundColor.Height);
        }

        private void XCHanged(object sender, EventArgs e)
        {
            double dpiWidth = (double)(pictureBox1.Width) / (double)(((int)widthSelect.Value));
            double dpiHeight = (double)(pictureBox1.Height) / (double)(((int)heightSelect.Value));
            pictureBoxService.MoveTo(new PointF((float)xCoordinate.Value * (float)dpiWidth, (float)yCoordinate.Value * (float)dpiHeight));
            
        }

        private void YChanged(object sender, EventArgs e)
        {
            double dpiWidth = (double)(pictureBox1.Width) / (double)(((int)widthSelect.Value));
            double dpiHeight = (double)(pictureBox1.Height) / (double)(((int)heightSelect.Value));
            pictureBoxService.MoveTo(new PointF((float)xCoordinate.Value * (float)dpiWidth, (float)yCoordinate.Value * (float)dpiHeight));

        }

        private void MoveToCenter(object sender, EventArgs e)
        {
            pictureBoxService.Center = new PointF((float)(pictureBox1.Width / 2.0), (float)(pictureBox1.Height / 2.0));
            xCoordinate.Value = widthSelect.Value / 2;
            yCoordinate.Value = heightSelect.Value / 2;
        }
    }
}
