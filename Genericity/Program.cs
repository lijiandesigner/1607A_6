using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericity
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = SumClass<int>.Add(1, 2);
            float f = SumClass<float>.Add(2.3f, 3.2f);
            double d = SumClass<double>.Add(4.5, 5.4);

            Console.WriteLine("int 值为：" + i);
            Console.WriteLine("float 值为：" + f);
            Console.WriteLine("double 值为：" + d);
            Console.ReadKey();
        }
    }

    static class SumClass<T> where T : struct
    {
        public static T Add(T num1, T num2)
        {
            dynamic t1 = num1;
            dynamic t2 = num2;
            return t1 + t2;
        }
    }
}
