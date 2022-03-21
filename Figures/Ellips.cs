using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Ellips: Figure
    {
        int x, y, width, height;

        public Ellips(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void Draw()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ellips("+this.x+","+this.y+","+this.width+","+this.height+")");
        }
    }
}
