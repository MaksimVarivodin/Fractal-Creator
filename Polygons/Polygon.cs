using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDZ
{
    public class Polygon
    {
        private Side[] sides;
        public Side[] Sides { 
            protected set { 
                sides = value;  
            }
            get {
                if (sides != null) {
                    return sides;
                }
                return new Side[0];
            }
        }
        public Polygon(Side[] sides ) 
        {
            this.sides = sides;            
        }
        public delegate PointF? CenterPolygon(Polygon poly);
        protected static Polygon RotatePolygon(CenterPolygon calculation, Polygon poly, double angle) {
            PointF? temp = calculation(poly);
            PointF center;
            if (temp == null)
            {
                return new Polygon(new Side[0]);
            }
            else {
                center = new PointF(temp.Value.X, temp.Value.Y);
            }
           return RotatePolygon(center, poly, angle);
        }
        public static Polygon RotatePolygon(PointF center, Polygon poly, double angle)
        {
            double radianAngle = angle * (Math.PI / 180),
                    alpha = Math.Cos(radianAngle),
                    beta = Math.Sin(radianAngle);
            Side[] lines = new Side[poly.Sides.Length];

            for (int i = 0; i < poly.Sides.Length; i++)
            {
                float Ax = ((float)(alpha * (poly.Sides[i].A.X - center.X) - beta * (poly.Sides[i].A.Y - center.Y) + center.X));
                float Ay = ((float)(beta * (poly.Sides[i].A.X - center.X) + alpha * (poly.Sides[i].A.Y - center.Y) + center.Y));
                float Bx = ((float)(alpha * (poly.Sides[i].B.X - center.X) - beta * (poly.Sides[i].B.Y - center.Y) + center.X));
                float By = ((float)(beta * (poly.Sides[i].B.X - center.X) + alpha * (poly.Sides[i].B.Y - center.Y) + center.Y));
                lines[i] = new Side(new PointF(Ax, Ay), new PointF(Bx, By));
            }
            return new Polygon(lines);
        }
        public static PointF CalculateCenterOfMass(Polygon poly) {
            float xCenter = 0;
            float yCenter = 0;
            foreach (Side side in poly.Sides) {
                xCenter += side.A.X;// беру первую вершину
                yCenter += side.A.Y;// с каждой стороны
            }
            return new PointF(xCenter/(float)poly.Sides.Length, yCenter/(float)poly.Sides.Length);
        }
        public static double EvkildFormula(PointF A, PointF B) {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        public static List<double> CalculateCenterMassDistances(Polygon poly) { 
            PointF centerOfMass = CalculateCenterOfMass(poly);
            List<double> diameters = new List<double>(poly.Sides.Length);
            
            foreach (Side side in poly.Sides)
            {
                // формула Эвклида
                diameters.Add(EvkildFormula(side.A, centerOfMass));
            }
            return diameters;            
        }
        public static double CalculateAnyPolygonRadius(Polygon poly) {
            return CalculateCenterMassDistances(poly).Max();
        }
        public static PointF? CalculateAnyPoligonCircumCenter(Polygon poly) {
            if (poly.sides.Length <= 2)
                return null;
            else { 
                float middleX = (poly.Sides[0].A.X + poly.Sides[1].A.X) /2;
                float middleY = (poly.Sides[0].A.Y + poly.Sides[1].A.Y) / 2;
                float distance = (float)EvkildFormula(poly.Sides[1].A, poly.Sides[0].A);
                float radius = (float)CalculateAnyPolygonRadius(poly);
                return new PointF(
                                  middleX + (radius / distance * (poly.Sides[0].A.Y - poly.Sides[1].A.Y)),
                                  middleY + (radius / distance * (poly.Sides[1].A.X - poly.Sides[0].A.X))
                                  );

            }
        }
        public static Polygon RotateAnyPoligon(Polygon poly, double angle) {
            return RotatePolygon(CalculateAnyPoligonCircumCenter, poly, angle);
        }
        public static Polygon MovePolygon(Polygon poly, PointF center, PointF newCenter) {
            float xMove = newCenter.X - center.X;
            float yMove = newCenter.Y - center.Y;

            Side[] newSides = new Side[poly.Sides.Length];
            for (int i = 0; i < newSides.Length; i++) {
                Side newSide = new Side(new PointF(poly.Sides[i].A.X + xMove, poly.Sides[i].A.Y + yMove),
                                         new PointF(poly.Sides[i].B.X + xMove, poly.Sides[i].B.Y + yMove));
                newSides[i] = newSide;
            }
            return new Polygon(newSides);
        }
    }
}
