using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Moduls
{
    public class Counter
    {

        private int min;

        public int Min
        {
            get { return min; }
            set
            {
                if (min >= 0 && min <= 100)
                    this.min = value;
                else
                    Console.WriteLine();
            }
        }


        private int max;

        public int Max
        {
            get { return max; }
            set
            {
                if (max >= 0 && max <= 100)
                    this.max = value;
                else
                    Console.WriteLine();
            }
        }


        private int currentData;

        public int CurrentData
        {
            get { return currentData; }
            set { currentData = value; }
        }


        public Counter()
        {
            min = 0;
            max = 0;
        }
        public Counter(int min, int max)
        {
            Max = max;
            Min = min;
            currentData = min;
        }
        public void increment()
        {
            if (currentData < max)
                currentData++;
        }
        public void decrement()
        {
            if (currentData > min)
                currentData--;
        }

        public void ShowData() { Console.WriteLine($"Currently: {currentData}"); }

    }
}
