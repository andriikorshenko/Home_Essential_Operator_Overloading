using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_005
{
    internal struct Point
    {
        private int _x;
        private int _y;
        private int _z;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int Z { get => _z; set => _z = value; }

        public Point(int x, int y, int z)
        {
            _x = x; 
            _y = y; 
            _z = z; 
        }

        public static Point operator +(Point p1, Point p2)
            => new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);

        public override string ToString() 
            => $"new Point has coordinates X: {X}, Y: {Y}, Z: {Z}.";
    }
}
