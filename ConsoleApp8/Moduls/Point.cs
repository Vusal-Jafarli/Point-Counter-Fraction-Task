using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Moduls
{
    public class Point
    {
        private int x;

        public int X
        {
            get { return x; }
            set
            {
                if (x >= 0 && x <= 100)
                    this.x = value;
                else
                    Console.WriteLine("Yanlis secim.");
            }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set
            {
                if (y >= 0 && y <= 100)
                    this.y = value;
                else
                    Console.WriteLine("Yanlis secim.");
            }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void showData()
        {
            Console.WriteLine($"X:{x}\nY:{y}");
        }
    }
}
//ByVC