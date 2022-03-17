using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Square:Figure
    {
        int x, y, a;
        
        public Square(int x, int y, int a)
        {
            this.y = y;
            this.x = x;
            this.a = a;
        }
        public override void Draw()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Square("+this.x+","+this.y+","+this.a+")");
        }
    }
}
