using IDZ.Interfaces;
using IDZ.Polygons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ.Services
{
    public class LineStarPolygonService: PolygonServiceInterface
    {
        private LineStarPolygon poly;
        public Polygon polygon { get
            {
                return poly;
            }
        }

        public int Start_index { get => start_index; }
        public int End_index { get => end_index;  }

        private PointF center;
        private int start_index;
        private int end_index;

        public LineStarPolygonService(RegularKochPolygonService service)
        {   
            poly = (LineStarPolygon)RegularKochPolygon.GenerateLineStarPolygon((RegularKochPolygon)service.polygon);
            center = service.Center;
            start_index = 0;
            end_index = poly.Sides.Length;
        }

        public void Draw(Graphics graphics, Color color, int penWidth)
        {
            for (int i = start_index; i < end_index; i++)
            {
                poly.Sides[i].DrawSide(graphics, color, penWidth);
            }
            
        }



        public void Move(float moveX, float moveY)
        {
            PointF newCenter = new PointF();
            newCenter.X = center.X + moveX;
            newCenter.Y = center.Y + moveY;
            MoveTo(newCenter);
        }

        public void MoveByX(float moveValue)
        {
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

        public void MoveTo(PointF newCenter)
        {
            poly = (LineStarPolygon)Polygon.MovePolygon(poly, center, newCenter);
        }

        public void Rotate(double angle)
        {
            this.poly = LineStarPolygon.RotatePolygon(center, poly, angle);
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
