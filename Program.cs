using System;
using System.Collections.Generic;

namespace lab1
{

    class Program
    {
        static void Main(string[] args)
        {

            List<Figure> list = new List<Figure>();

            list.Add(new Triangle(30, 30, 25, 40, 50, 60));
            list.Add(new Rectangle(90, 50, 60, 40));
            list.Add(new Circle(250, 250, 30));
            list.Add(new Square(100, 100, 40));
            list.Add(new Ellips(300, 300, 50, 15));
            list.Add(new Rhombus(500,500,560,500,500,600,660,600));

            foreach (var elem in list)
            {
                elem.Draw();
            }

            

            Console.ReadLine();

        }
    }
}
