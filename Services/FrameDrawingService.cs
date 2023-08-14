using IDZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ.Services
{
    public class FrameDrawingService:PolygonServiceInterface
    {
        private RegularKochPolygonService kochPolygonService;
        private LineStarPolygonService lineStarPolygonService;
        private delegate void CalculationHandler();
        private event CalculationHandler? Calculation;
        PointF  center      ;
        double  radius      ;
        double  angle       ;
        int     vertices    ;
        int     kochDepth   ;
        public int StartIndex { get {
                return kochPolygonService.Start_index;
            } 
        }
        public int EndIndex {
            get {
                return kochPolygonService.End_index;
            }
        }
        public int PointsCount
        {
            get { 
                return kochPolygonService.polygon.Sides.Length;
            }
        }
        public PointF Center    { 
            get{
                return center      ;
            }
            set {
                center      = value;
                if (Calculation == null)
                Calculation += NewValueSet;
            } 
        }
        public double Radius    {   
            get{
                return radius      ;
            }
            set{
                radius       = value;
                if (Calculation == null)
                    Calculation += NewValueSet;
            }
        }
        public int Vertices     {
            get{
                return vertices    ;
            }
            set{
                vertices     = value;
                if (Calculation == null)
                    Calculation += NewValueSet;
            }
        }
        public int KochDepth    {
            get { 
                return kochDepth;
            }
            set{
                kochDepth    = value;
                if (Calculation == null)
                    Calculation += NewValueSet;
            }
        }

        public double Angle { 
            get => angle;
            set { 
                angle = value;
                if (Calculation == null)
                    Calculation += NewValueSet;
            } 
        }

        void NewValueSet() {
            int?start = null;
            int? end = null;
            if (kochPolygonService != null) {
                start = kochPolygonService.Start_index;
                end = kochPolygonService.End_index;
            }
            
            kochPolygonService = new RegularKochPolygonService(center, radius, vertices, kochDepth);
            lineStarPolygonService = new LineStarPolygonService(kochPolygonService);
            kochPolygonService.Rotate(angle);
            lineStarPolygonService.Rotate(angle);
            if (start!= null && end.Value >= kochPolygonService.End_index)
            SetDrawingRange(start.Value, end.Value);
        }
        public FrameDrawingService(PointF center, double radius, int vertices, int kochDepth) {
            this.center = center;
            this.radius = radius;
            this.vertices = vertices;
            this.kochDepth = kochDepth;
            NewValueSet();
        }

        public void DrawLineStar(Graphics graphics, Color lineColor, int lineWidth)
        {
            
            Calculation?.Invoke();
            lineStarPolygonService.Draw(graphics, lineColor, lineWidth);
            Calculation = null;
        }
        public void DrawKoch(Graphics graphics, Color kochColor, int kochWidth)
        {
            Calculation?.Invoke();
            kochPolygonService.Draw(graphics, kochColor, kochWidth);
            Calculation = null;
        }

        public void Move(float moveX, float moveY)
        {
            Calculation?.Invoke();
            kochPolygonService.Move(moveX, moveY);
            lineStarPolygonService.Move(moveX, moveY);
            Calculation = null;
        }

        public void MoveByX(float moveValue)
        {
            Calculation?.Invoke();
            kochPolygonService.MoveByX(moveValue);
            lineStarPolygonService.MoveByX(moveValue);
            Calculation = null;
        }

        public void MoveByY(float moveValue)
        {
            Calculation?.Invoke();
            kochPolygonService.MoveByY(moveValue);
            lineStarPolygonService.MoveByY(moveValue);
            Calculation = null;
        }

        public void MoveTo(PointF newCenter)
        {
            Calculation?.Invoke();
            kochPolygonService.MoveTo(newCenter);
            lineStarPolygonService.MoveTo(newCenter);
            Calculation = null;
        }

        public void SetDrawingRange(int startIndex, int endIndex)
        {            
            lineStarPolygonService.SetDrawingRange(startIndex, endIndex);
            kochPolygonService.SetDrawingRange(startIndex, endIndex);            
        }
    }
}
