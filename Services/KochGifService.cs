using AnimatedGif;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace IDZ.Services
{
    public class KochGifService
    {
        FrameService frameService;
        public Color BackFill
        {
            get
            {
                return frameService.BackFill;
            }
            set
            {
                frameService.BackFill = value;
            }
        }
        public Color KochColor
        {
            get
            {
                return frameService.KochColor;
            }
            set
            {
                frameService.KochColor = value;
            }
        }
        public Color LineColor
        {
            get
            {
                return frameService.LineColor;
            }
            set
            {
                frameService.LineColor = value;
            }
        }
        public int KochWidth
        {
            get
            {
                return frameService.KochWidth;
            }
            set
            {
                frameService.KochWidth = value;
            }
        }
        public int LineWidth
        {
            get
            {
                return frameService.LineWidth;
            }
            set
            {
                frameService.LineWidth = value;
            }
        }
        public int Width
        {
            get
            {
                return frameService.Width;
            }
            set
            {
                frameService.Width = value;
            }
        }
        public int Height
        {
            get
            {
                return frameService.Height;
            }
            set
            {
                frameService.Height = value;
            }
        }
        public double Angle
        {
            get
            {
                return frameService.Angle;
            }
            set
            {
                frameService.Angle = value;
            }
        }
        public KochGifService(PointF center, double radius, int vertices, int kochDepth)
        { 
            frameService = new FrameService(center, radius, vertices, kochDepth);
        }
        public KochGifService(FrameService frameService) { 
            this.frameService = frameService;
        }
        public async void SaveGif(double degrees, double frames,  string Path, string picsPath)
        {          
            using (var gif = AnimatedGif.AnimatedGif.Create(Path, 0))
            {
                degrees = degrees < 0 ? degrees * (-1) : degrees == 0 ? 1 : degrees;                
                int framesCount = (int)(frames * degrees);
                double i = 0;
                double dx = (double)frameService.PointsCount / framesCount;

                frameService.KochWidth = 3;
                frameService.LineWidth = 3;
                Bitmap image = frameService.CreateBackFillFrame();
                Graphics g = Graphics.FromImage(image);
                g.CompositingQuality = CompositingQuality.HighQuality;
                gif.AddFrame(image, delay: 5, GifQuality.Bit8);
                int delayInTasks = 50;
                for (; i < framesCount; i+= 1.0)
                {
                    await Task.Run(() =>
                    {
                        Task.Delay(delayInTasks).Wait();
                        frameService.SetDrawingRange((int)(i * dx), (int)((i + 1.0) * dx));
                        frameService.DrawOnImage(ref image, ref g);
                        gif.AddFrame(image, delay: -1, GifQuality.Bit8);
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    });
                                       
                    
                }
                frameService.LineColor =Color.FromArgb(255, frameService.BackFill.R, frameService.BackFill.G, frameService.BackFill.B);
                frameService.KochColor = frameService.LineColor;
                
                i = 0;
                for (; i < framesCount; i += 1.0)
                {
                    await Task.Run(() =>
                    {
                        Task.Delay(delayInTasks).Wait();
                        frameService.SetDrawingRange((int)(i * dx), (int)((i + 1.0) * dx));
                        frameService.DrawOnImage(ref image, ref g);
                        if (i == 0) {
                            for(int j = 0; j < 4; j++)
                                gif.AddFrame(image, delay: -1, GifQuality.Bit8);
                        }
                        gif.AddFrame(image, delay: -1, GifQuality.Bit8);
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    });

                }
                gif.AddFrame(image, delay: 5, GifQuality.Bit8);
                image.Dispose();
                g.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
               
            }
        }        
        public void Move(float moveX, float moveY)
        {
            frameService.Move(moveX, moveY);
        }

        public void MoveByX(float moveValue)
        {
            frameService.MoveByX(moveValue);

        }

        public void MoveByY(float moveValue)
        {
            frameService.MoveByY(moveValue);
        }

        public void MoveTo(PointF newCenter)
        {
            MoveTo(newCenter);
        }

        /*
         public void create()
        {
            string pathPics = @"temp/";
            
            DirectoryInfo di1 = Directory.CreateDirectory(pathPics);
            

            center = new PointF(frameWidth/2, frameHeight/2);
            generator = new KochGenerator(depth, center, radius, vertices, angle);
            Bitmap[] pics = generator.GenerateFrames(frameWidth, frameHeight);            
            for (int i = 0; i < 360; i++) {
                pics[i].Save(pathPics + i.ToString() + ".jpg");
                pics[i].Dispose();
                
            }
            
            

            using (var gif = AnimatedGif.AnimatedGif.Create(FilePath, 0))
            {
                for (int i = 0; i< 360; i++) {                     
                    gif.AddFrame(Image.FromFile(pathPics + i.ToString() + ".jpg"), delayInTasks: -1, GifQuality.Bit8);                         
                }
                GC.Collect();
                gif.AddFrame(Image.FromFile(pathPics + "359.jpg"), delayInTasks: 10, GifQuality.Bit8);
                for (int i = 359; i > -1; i--)
                {
                    gif.AddFrame(Image.FromFile(pathPics + i.ToString() + ".jpg"), delayInTasks: -1, GifQuality.Bit8);                   
                }
                GC.Collect();
            }
            foreach (FileInfo file in di1.GetFiles())
            {
                file.Delete();
            }
           
            di1.Delete();            
        }
         */
    }
}
