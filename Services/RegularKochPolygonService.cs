using IDZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    public class RegularKochPolygonService: PolygonServiceInterface
    {
        
        private RegularKochPolygon poly;
        public Polygon polygon
        {
            get
            {
                return poly;
            }
        }
        private PointF center;
        private int start_index;
        private int end_index;
        public PointF Center { get { return center; } }

        public int Start_index { get => start_index;  }
        public int End_index { get => end_index; }

        public RegularKochPolygonService(PointF center, double radius, int vertices, int kochDepth)
        {
            this.center = center;
            this.poly = RegularKochPolygon.GenerateRegularKochPolygon(center, radius, vertices, kochDepth);
            start_index = 0;
            end_index = poly.Sides.Length;
        }
        public void Rotate(double angle) {
            RegularKochPolygon temp = RegularKochPolygon.RotatePolygon(center, poly, angle);
            this.poly = temp;
        }
        public void Draw(Graphics graphics, Color color, int penWidth) {
            for (int i = Start_index; i < end_index; i++)
            {
                poly.Sides[i].DrawSide(graphics, color, penWidth);
            }
        }
       
        public void MoveTo(PointF newCenter) {
            poly = (RegularKochPolygon)Polygon.MovePolygon(poly, center, newCenter);
        }
        public void MoveByX(float moveValue) {
            PointF newCenter = new PointF();
            newCenter.Y = center.Y;
            newCenter.X = center.X + moveValue;
            MoveTo(newCenter);
        }
        public void MoveByY(float moveValue)
        {
            PointF newCenter = new PointF();
            newCenter.X = center.X;
            newCenter.Y = center.Y + moveValue;
            MoveTo(newCenter);
        }
        public void Move(float moveX, float moveY) {
            PointF newCenter = new PointF();
            newCenter.X = center.X + moveX;
            newCenter.Y = center.Y + moveY;
            MoveTo(newCenter);
        }

        public void SetDrawingRange(int startIndex, int endIndex)
        {
            if (polygon != null && endIndex - startIndex <= polygon.Sides.Length && endIndex - startIndex > 0)
            {
                this.start_index = startIndex; 
                this.end_index = endIndex;   
            }
        }
    }
}
