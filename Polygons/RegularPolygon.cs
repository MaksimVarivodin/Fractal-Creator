using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    public class RegularPolygon : Polygon
    {
        public RegularPolygon(Side[] array) : base(array)
        {

        }
        public static PointF? CalculateRegularCircumCenter(Polygon poly) {
            return Polygon.CalculateCenterOfMass(poly);
        }
        public static double CalculateRegularRadius(RegularPolygon poly) { 
            PointF center = Polygon.CalculateCenterOfMass(poly);
            return Polygon.EvkildFormula(poly.Sides[0].A, center);
        }
        public static RegularPolygon RotateRegularPolygon(RegularPolygon poly, double angle) {
            return (RegularPolygon)Polygon.RotatePolygon(CalculateRegularCircumCenter, poly, angle);
        }
        public static RegularPolygon GenerateRegularPolygon(PointF center, double radius, int vertices)
        {
            if (vertices <= 2) {
                return new RegularPolygon(new Side[0]);
            }
            Side[] array = new Side[vertices];
            double radian = 2 * Math.PI / (double)vertices;
            float Ax = center.X + (float)(radius * Math.Cos(0));
            float Ay = center.Y + (float)(radius * Math.Sin(0));
            for (int i = 1; i < vertices + 1; i++)
            {
                
                float Bx = center.X + (float)(radius * Math.Cos((i) * radian));
                float By = center.Y + (float)(radius * Math.Sin((i) * radian));
                array[i - 1] = new Side(new PointF(Ax, Ay), new PointF(Bx, By));
                Ax = Bx;
                Ay = By;
            }
            return new RegularPolygon(array);
        }
    }
}
