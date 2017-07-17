using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12Part2
{
    class Time
    {
        private int hours, minutes, seconds;

        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public Time(int h, int m)
        {
            hours = h;
            minutes = m;
            seconds = 0;
        }

        public Time(int h)
        {
            hours = h;
            minutes = 0;
            seconds = 0;
        }

        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Time theTime = new Time(7, 15, 0);
            Time aTime = new Time(8, 0);
            Time someTime = new Time();

            Console.ReadKey();
        }
    }
}
