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


            
           

            Point point = new Point(1, 1, 1, 1, 1, 2, 2, 2, 2, 2, true, true, true, true, true,
                "123", "123", "123", "123", "123", "123", "123", "123", "123", "123");
            /*Console.WriteLine(point1.GetHashCode());
            Console.WriteLine(point1.Equals(point));*/

            

            Point point1 = new Point(1,1,1,1,1,2,2,2,2,2,true, true, true, true, true, 
                "123", "123", "123", "123", "123", "123", "123", "123", "123", "123");

            Point point2 = new Point(2, 1, 1, 1, 1, 2, 2, 2, 2, 2, true, true, true, true, true,
                "123", "123", "123", "123", "123", "123", "123", "123", "123", "123");

            Console.WriteLine(point.Equals(point1));
            Console.WriteLine(point1.Equals(point2));

            Console.ReadKey();

        }
    }



    public struct Point
    {
        private int x1;
        private int x2;
        private int x3;
        private int x4;
        private int x5;
        private int y1;
        private int y2;
        private int y3;
        private int y4;
        private int y5;
        private bool b1;
        private bool b2;
        private bool b3;
        private bool b4;
        private bool b5;
        private string s1;
        private string s2;
        private string s3;
        private string s4;
        private string s5;
        private string s6;
        private string s7;
        private string s8;
        private string s9;
        private string s10;


        public Point(int x1, int x2, int x3, int x4, int x5, int y1, int y2, int y3, int y4, int y5, bool b1, 
            bool b2, bool b3, bool b4, bool b5, string s1, string s2, string s3, string s4, 
            string s5, string s6, string s7, string s8, string s9, string s10)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.x5 = x5;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
            this.y5 = y5;
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.b4 = b4;
            this.b5 = b5;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
            this.s5 = s5;
            this.s6 = s6;
            this.s7 = s7;
            this.s8 = s8;
            this.s9 = s9;
            this.s10 = s10;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point)) return false;



            Point p = (Point)obj;

            if (x1.GetHashCode() == p.x1.GetHashCode() & x2.GetHashCode() == p.x2.GetHashCode()
                & x3.GetHashCode() == p.x3.GetHashCode() & x4.GetHashCode() == p.x4.GetHashCode()
                & x5.GetHashCode() == p.x5.GetHashCode() & y1.GetHashCode() == p.y1.GetHashCode()
                & y3.GetHashCode() == p.y3.GetHashCode() & y4.GetHashCode() == p.y4.GetHashCode()
                & y5.GetHashCode() == p.y5.GetHashCode() & y5.GetHashCode() == p.y5.GetHashCode()
                & b1.GetHashCode() == p.b1.GetHashCode() & b2.GetHashCode() == p.b2.GetHashCode()
                & b3.GetHashCode() == p.b3.GetHashCode() & b4.GetHashCode() == p.b4.GetHashCode()
                & b5.GetHashCode() == p.b5.GetHashCode() & s1.GetHashCode() == p.s1.GetHashCode()
                & s2.GetHashCode() == p.s2.GetHashCode() & s3.GetHashCode() == p.s3.GetHashCode()
                & s4.GetHashCode() == p.s4.GetHashCode() & s5.GetHashCode() == p.s5.GetHashCode()
                & s6.GetHashCode() == p.s6.GetHashCode() & s7.GetHashCode() == p.s7.GetHashCode()
                & s8.GetHashCode() == p.s8.GetHashCode() & s9.GetHashCode() == p.s9.GetHashCode()
                & s10.GetHashCode() == p.s10.GetHashCode())
            {
                return ((x1 == p.x1) && (x2 == p.x2) && (x3 == p.x3) && (x4 == p.x4) && (x5 == p.x5)
                    & (y1 == p.y1) && (y2 == p.y2) && (y3 == p.y3) && (y4 == p.y4) && (y5 == p.y5)
                    & (b1 == p.b1) && (b2 == p.b2) && (b3 == p.b3) && (b4 == p.b4) && (b5 == p.b5)
                    & (s1 == p.s1) && (s2 == p.s2) && (s3 == p.s3) && (s4 == p.s4) && (s5 == p.s5)
                    & (s6 == p.s6) && (s7 == p.s7) && (s8 == p.s8) && (s9 == p.s9) && (s10 == p.s10));
                    
            }
            else return false;

            //
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashcode = 13;

                hashcode = (hashcode * 11) + x1.GetHashCode();
                hashcode = (hashcode * 11) + x2.GetHashCode();
                hashcode = (hashcode * 11) + x3.GetHashCode();
                hashcode = (hashcode * 11) + x4.GetHashCode();
                hashcode = (hashcode * 11) + x5.GetHashCode();
                hashcode = (hashcode * 11) + y1.GetHashCode();
                hashcode = (hashcode * 11) + y2.GetHashCode();
                hashcode = (hashcode * 11) + y3.GetHashCode();
                hashcode = (hashcode * 11) + y4.GetHashCode();
                hashcode = (hashcode * 11) + y5.GetHashCode();
                hashcode = (hashcode * 11) + b1.GetHashCode();
                hashcode = (hashcode * 11) + b2.GetHashCode();
                hashcode = (hashcode * 11) + b3.GetHashCode();
                hashcode = (hashcode * 11) + b4.GetHashCode();
                hashcode = (hashcode * 11) + b5.GetHashCode();
                hashcode = (hashcode * 11) + s1.GetHashCode();
                hashcode = (hashcode * 11) + s2.GetHashCode();
                hashcode = (hashcode * 11) + s3.GetHashCode();
                hashcode = (hashcode * 11) + s4.GetHashCode();
                hashcode = (hashcode * 11) + s5.GetHashCode();
                hashcode = (hashcode * 11) + s6.GetHashCode();
                hashcode = (hashcode * 11) + s7.GetHashCode();
                hashcode = (hashcode * 11) + s8.GetHashCode();
                hashcode = (hashcode * 11) + s9.GetHashCode();
                hashcode = (hashcode * 11) + s10.GetHashCode();

                return hashcode;
            }
        }
    }
}
