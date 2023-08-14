using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    public class Side
    {

        public PointF A;
        public PointF B;
        public Side(PointF A, PointF B)
        {
            this.A = A;
            this.B = B;
        }
        public void DrawSide(Graphics graphics, Color color, int penWidth)
        {
            graphics.DrawLine(new Pen(color, penWidth), this.A, this.B);
        }
    }
}
