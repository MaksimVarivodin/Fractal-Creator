using IDZ.Polygons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    class RegularKochPolygon : RegularPolygon
    {
        public RegularKochPolygon(Side[] sides) : base(sides)
        {
        }
        public RegularKochPolygon(Polygon otherPolygon) : base(otherPolygon.Sides) { }

        public static RegularKochPolygon GenerateRegularKochPolygon(PointF center, double radius, int vertices, int kochDepth) {
            if (vertices <= 2)
            {
                return new RegularKochPolygon(new Side[0]);
            }
            RegularPolygon reg = RegularPolygon.GenerateRegularPolygon(center, radius, vertices);
            Side[] sides = reg.Sides;
            List<Side> kochSidesList = new List<Side>();
            
            foreach (Side side in sides)
            {
                KochCurve curve = new KochCurve();
                kochSidesList.AddRange(curve.RecursivlyCalculateCurve(side, kochDepth));
            }
                    
            Side[] kochSidesArray = kochSidesList.ToArray();
            return new RegularKochPolygon(kochSidesArray);
        }
        
        public static LineStarPolygon GenerateLineStarPolygon(RegularKochPolygon poly)
        {
            PointF center = RegularPolygon.CalculateRegularCircumCenter(poly).Value;
            Side[] sides = new Side[poly.Sides.Length];
            for (int i = 0; i < poly.Sides.Length; i++)
            {
                sides[i] = new Side(center, poly.Sides[i].A);
            }
            return new LineStarPolygon(sides);
        }
        public static new RegularKochPolygon RotatePolygon(PointF center, Polygon poly, double angle)
        {
            Side[] array = Polygon.RotatePolygon(center, poly, angle).Sides;
            return new RegularKochPolygon(array);   
        }
    }
}
