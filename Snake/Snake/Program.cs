using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';            
            Point p2 = new Point(4, 5, '#');
            p1 = p2;
            p2.x = 2;
            p2.y = 6;
            Console.ReadLine();



        }
    }
}
