using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Rectangle:Figure
    {
        int x1, y1, x2, y2;

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            
        }
        public override void Draw()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Rectangle(" + this.x1 + "," + this.y1 + "," + this.x2 + "," + this.y2+")");
        }
    }
}
