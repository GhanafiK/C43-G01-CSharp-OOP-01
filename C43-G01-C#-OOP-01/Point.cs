using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_C__OOP_01
{
    internal struct Point
    {
        public int x;
        public int y;

        public Point(int num)
        {
            this.x = this.y = num;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x} , {y})";
        }

    }
    
}
