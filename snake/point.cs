using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    struct point
    {
        public int x;
        public int y;
        public point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator==(point p1,point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }
        public static bool operator!=(point p1,point p2)
        {
            return !(p1 == p2);
        }
        public static point operator+(point p1,point p2)
        {
            return new point(p1.x + p2.x, p1.y + p2.y);
        }
    }
}
