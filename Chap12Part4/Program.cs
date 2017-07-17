using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12Part4
{
    class Time
    {
        private int hour, minute, second;

        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public void setTime(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public override String ToString()
        {
            return hour + ":" + minute + ":" + second;
        }

        public String displayTime()
        {
            return hour + ":" + minute + ":" + second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time theTime = new Time(18, 23, 0);
            Console.WriteLine("The value of theTime is " + theTime.ToString());
            Object obj = new Object();
            Console.WriteLine(obj.ToString());
            Console.WriteLine(theTime.displayTime());
            Console.ReadKey();
        }
    }
}
