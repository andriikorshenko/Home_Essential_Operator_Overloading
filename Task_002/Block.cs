using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class Block
    {
        private int _x;
        private int _y;
        private int _z;
        private int _w;

        public Block() : this(0, 0, 0, 0) { }

        public Block(int x, int y, int z, int w)
        {
            _x = x;
            _y = y;
            _z = z;
            _w = w;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y, _z, _w);
        }

        public override bool Equals(Object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                Block b = (Block)obj;
                return (_x == b._x) && (_y == b._y) 
                    && (_z == b._z) && (_w == b._w);
            }
        }

        public override string ToString()
            => $"Block ({_x}, {_y}, {_z}, {_w})";
    }
}
