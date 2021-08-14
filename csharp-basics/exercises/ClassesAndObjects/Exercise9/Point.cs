using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
{
    class Point
    {
        private double _x;
        private double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void SwapPoints(Point p1, Point p2)
        {
            double change1 = p1._x;
            double change2 = p1._y;

            p1._x = p2._x;
            p1._y = p2._y;

            p1._x = change1;
            p2._y = change2;
        }
    }
}
