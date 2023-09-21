using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point
    {
        private int x;
        private int y;

        public int X
        { get { return x; } }

        public int Y
        { get { return y; } }

        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
    }
}
