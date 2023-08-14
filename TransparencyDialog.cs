using IDZ.Properties;
using IDZ.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IDZ
{
    public partial class TransparencyDialog : Form
    {
        private Color back;
        private int alfa;
        public Color NewAlfa { get { return back; } }
        public TransparencyDialog(Color back, int alfa)
        {
            InitializeComponent();
            this.back = back;
            this.alfa = alfa;
            numericUpDown1.Value = (decimal)alfa;
            DrawImageWithTransparency();
            
        }
        private void DrawImageWithTransparency() {
            string path = "C:\\Projects\\ComputerGraphics\\ИДЗ\\IDZ\\Resources\\Transparency_Triangle_Transformed.jpg";
            Bitmap triangle = new(path);
            back = Color.FromArgb(alfa, back.R, back.G, back.B);
            var fill = ColorFillerService.CreateFilledRectangle(back, triangle.Width, triangle.Height);
            Graphics g = Graphics.FromImage(triangle);
            g.CompositingMode = CompositingMode.SourceOver;
            fill.MakeTransparent();
            g.DrawImage(fill, new Point(0, 0));
            g.Dispose();
            pictureBox1.Image = triangle;
        }
        private void ChangeTransparency(object sender, EventArgs e)
        {
            alfa = ((int)numericUpDown1.Value);
            DrawImageWithTransparency();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
