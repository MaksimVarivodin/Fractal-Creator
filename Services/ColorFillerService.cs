using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace IDZ.Services
{
    public class ColorFillerService
    {
        public static Bitmap CreateFilledRectangle(Color fillColor, int rectangleWidth, int rectangleHeight) {
            if (rectangleHeight <= 0 || rectangleWidth <= 0)
                throw new ArgumentException("Size argument was invalid.");
            Bitmap image = new Bitmap(rectangleWidth, rectangleHeight);
            Graphics g = Graphics.FromImage(image);
            Brush brush = new SolidBrush(fillColor);
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.FillRectangle(brush, 0, 0, rectangleWidth, rectangleHeight);
            g.Dispose();
            return image;
        }
    }
}
