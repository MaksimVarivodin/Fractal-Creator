using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ.Polygons
{
    public class LineStarPolygon : Polygon
    {
        public LineStarPolygon(Side[] sides) : base(sides)
        {
        }
        public LineStarPolygon(Polygon otherPolygon):base(otherPolygon.Sides)
        {
            
        }
        public static new LineStarPolygon RotatePolygon(PointF center, Polygon poly, double angle) {
            Side[] array = Polygon.RotatePolygon(center, poly, angle).Sides;
            return new LineStarPolygon(array);
        }
    }
}
