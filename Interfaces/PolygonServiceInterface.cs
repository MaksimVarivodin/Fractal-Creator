using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ.Interfaces
{
    internal interface PolygonServiceInterface
    {
        void MoveTo(PointF newCenter);
        void MoveByX(float moveValue);
        void MoveByY(float moveValue);
        void Move(float moveX, float moveY);
    }
}
