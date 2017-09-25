using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GetHashCodeExClass getHashCodeEx1 = new GetHashCodeExClass();
            GetHashCodeExClass getHashCodeEx2 = new GetHashCodeExClass();
            Console.WriteLine(getHashCodeEx1.GetHashCode());
            Console.WriteLine(getHashCodeEx2.GetHashCode());
            Console.WriteLine();

            GetHashCodeExStruct struct1 = new GetHashCodeExStruct();
            GetHashCodeExStruct struct2 = new GetHashCodeExStruct();
            Console.WriteLine(struct1.GetHashCode());
            Console.WriteLine(struct2.GetHashCode());
            Console.ReadKey();

        }
    }

    public class GetHashCodeExClass
    {
        int x = 3;
        string s = "String";
        object o;
    }

    public struct GetHashCodeExStruct
    {
        int x;
        string s;
        object o;

    }
}
