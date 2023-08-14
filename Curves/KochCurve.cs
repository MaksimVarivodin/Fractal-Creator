using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    public class KochCurve
    {
        List<Side> sides;
        public KochCurve() { 
            sides = new List<Side>();
        }  
        public List<Side> RecursivlyCalculateCurve(Side side, int depth) {
            sides.Add(side);
            if (depth != 0)
            {
                // counting new Points
                PointF pA = new PointF((2 * side.A.X + side.B.X) / 3, (2 * side.A.Y + side.B.Y) / 3);
                PointF pB = new PointF((side.A.X + side.B.X) / 2 + (side.B.Y - side.A.Y) / (2 * (float)Math.Sqrt(3)), (side.A.Y + side.B.Y) / 2 + (side.A.X - side.B.X) / (2 * (float)Math.Sqrt(3)));
                PointF pC = new PointF((side.A.X + 2 * side.B.X) / 3, (side.A.Y + 2 * side.B.Y) / 3);
                // passing to the function to continue recursive count
                RecursivlyCalculateCurve(new Side(side.A, pA), depth -1);
                RecursivlyCalculateCurve(new Side(pA, pB), depth - 1);
                RecursivlyCalculateCurve(new Side(pB, pC), depth - 1);
                RecursivlyCalculateCurve(new Side(pC, side.B), depth - 1);                
            }
            return sides;
        }
    }
}
