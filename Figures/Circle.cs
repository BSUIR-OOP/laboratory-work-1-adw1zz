using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Circle: Figure
    {
        int x, y, r;
        
        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public override void Draw()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Circle("+this.x+","+this.y+","+this.r+")");
        }
    }
}
