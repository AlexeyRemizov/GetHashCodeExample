using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeExample
{
    //GetHashCode возвращает одинаковые значения хеш-кодов, но при первоначальном сравнении 
    //c помощью переопределенного метода Equals "point" и "point1" мы получаем false
    //После того, как поменяли значение "point1" получаем при сравнении true, что означает равенство 
    class Program
    {
        static void Main(string[] args)
        {


            Point point = new Point(1, 11);
            Console.WriteLine(point.GetHashCode());

            Point point1 = new Point(11, 1);
            Console.WriteLine(point1.GetHashCode());
            Console.WriteLine(point1.Equals(point));

            if (point1.Equals(point) == false)
            {
                Console.WriteLine("Different types");
            }
            else Console.WriteLine("The same types");

            point1 = new Point(1,11);
            if (point1.Equals(point) == false)
            {
                Console.WriteLine("Different types");
            }
            else Console.WriteLine("The same types");
  

            Console.ReadKey();

        }
    }



    public struct Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point)) return false;

            Point p = (Point)obj;
            return x == p.x & y == p.y;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }
    }
}
