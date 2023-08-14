using IDZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ.Services
{
    public class FrameService : FrameServiceInterface
    {
        private FrameDrawingService frameDrawing;
        Color   backFill    ;
        Color   kochColor   ;
        Color   lineColor   ;
        int     kochWidth   ;
        int     lineWidth   ;
        int     frameWidth  ;
        int     frameHeight ;

        public int PointsCount
        {
            get
            {
                return frameDrawing.PointsCount;
            }
        }
        public Color BackFill {
            get {
                return backFill;
            }
            set {
                backFill = value;
            }
        }
        public Color KochColor{
            get{
            return kochColor   ;
            }
            set{
            kochColor   = value;
            }
        }
        public Color LineColor{
            get{
            return lineColor   ;
            }
            set{
            lineColor   = value;
            }
        }
        public int KochWidth{
            get{
            return kochWidth   ;
            }
            set{
            kochWidth   = value;
            }
        }
        public int LineWidth{
            get{
            return lineWidth   ;
            }
            set{
            lineWidth   = value;
            }
        }
        public int Width { 
            get {
                return frameWidth;
            } 
            set {
                frameWidth = value;
            }
        }
        public int Height { 
            get {
                return frameHeight;
            }
            set {
                frameHeight = value;
            } 
        }
        public PointF Center
        {
            get
            {
                return frameDrawing.Center;
            }
            set
            {
                frameDrawing.Center = value;
                
            }
        }
        public double Radius
        {
            get
            {
                return Radius;
            }
            set
            {
                frameDrawing.Radius = value;                
            }
        }
        public int Vertices
        {
            get
            {
                return Vertices;
            }
            set
            {
                frameDrawing.Vertices = value;
            }
        }
        public int KochDepth
        {
            get
            {
                return frameDrawing.KochDepth;
            }
            set
            {
                frameDrawing.KochDepth = value;
            }
        }
        public double Angle { 
            get { 
                return frameDrawing.Angle;
            } 
            set { 
                frameDrawing.Angle = value;
            }
        }
        public FrameService()
        {
            
        }
        public FrameService(PointF center, double radius, int vertices, int kochDepth)
        {            
            frameDrawing = new FrameDrawingService(center, radius, vertices, kochDepth);
            kochColor = Color.White;
            lineColor = Color.FromArgb(85, 0, 0, 0);
            backFill = Color.FromArgb(23, 23, 23);
            kochWidth = 1;
            lineWidth = 1;
        }

        public Bitmap CreateFrame()
        {

            if (frameWidth == 0 && frameHeight == 0)
                return new Bitmap(1, 1);
            
            Bitmap image = new Bitmap(frameWidth, frameHeight);
            Graphics g = Graphics.FromImage(image);
            Brush brush = new SolidBrush(backFill);
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.FillRectangle(brush, 0, 0, frameWidth, frameHeight);
            
            frameDrawing.DrawLineStar(g, lineColor, lineWidth);
            frameDrawing.DrawKoch(g, kochColor, kochWidth);
            g.Dispose();
            return image;
        }
        public Bitmap CreateBackFillFrame() {
            if (frameWidth == 0 && frameHeight == 0)
                return new Bitmap(1, 1);
            Bitmap image = new Bitmap(frameWidth, frameHeight);
            Graphics g = Graphics.FromImage(image);
            Brush brush = new SolidBrush(backFill);
            g.FillRectangle(brush, 0, 0, frameWidth, frameHeight);
            g.Dispose();

            return image;
        }
        public void DrawOnImage(ref Bitmap image, ref Graphics g) {
            if (frameWidth == 0 && frameHeight == 0)
                return;          
            frameDrawing.DrawLineStar(g, lineColor, lineWidth);
            frameDrawing.DrawKoch(g, kochColor, kochWidth);
            
        }
        public void Move(float moveX, float moveY)
        {
            frameDrawing.Move(moveX, moveY);    
        }

        public void MoveByX(float moveValue)
        {
           frameDrawing.MoveByX(moveValue);

        }

        public void MoveByY(float moveValue)
        {
            frameDrawing.MoveByY(moveValue);
        }

        public void MoveTo(PointF newCenter)
        {
            frameDrawing.MoveTo(newCenter);
        }
        public void SetDrawingRange(int startIndex, int endIndex) { 
            frameDrawing.SetDrawingRange(startIndex, endIndex);
        }

        public void SaveFrame(ref Bitmap image, string Path)
        {
            image.Save(Path);
        }

    }
}
