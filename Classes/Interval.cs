using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public struct Interval
    {

        private int min;
        private int max;


        public int Min
        {
            get
            {
                return min;
            }
        }
        public int Max
        {
            get
            {
                return max;
            }
        }

        Random random = new Random();

        public int Get
        {
            get
            {
                return random.Next(min,max);
            }
        }

        public Interval(int minValue, int maxValue)
        {
            if (minValue < 0)
            {
                Console.WriteLine("min value < 0. set to 0");
                minValue = 0;
            }

            if (maxValue < 0)
            {
                Console.WriteLine("max value < 0. set to 0");
                maxValue = 0;
            }

            if (minValue > maxValue)
            {
                Console.WriteLine("Min value > max value. The values are reversed");
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
            }

            if (maxValue == minValue)
            {
                Console.WriteLine("Min value = max value. Max value has been increased to 10");
                maxValue = maxValue + 10;
            }
            min = minValue;
            max = maxValue;

        }
    }
    
}
