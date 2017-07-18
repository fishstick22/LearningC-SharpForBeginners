using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap14Part3
{
    public interface Shape
    {
        void setX(int newx);
        void setY(int newy);
        int getX();
        int getY();
        void move(int newx, int newy);
        //void draw();
    }

    public class Rectangle : Shape
    {
        int x, y, width, height;

        public Rectangle(int newx, int newy, int neww, int newh)
        {
            x = newx;
            y = newy;
            width = neww;
            height = newh;
        }

        public void setX(int newx)
        {
            x = newx;
        }

        public void setY(int newy)
        {
            y = newy;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void move(int newx, int newy)
        {
            x = newx;
            y = newy;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10, 20, 15, 30);

            Console.ReadKey();

        }
    }
}
