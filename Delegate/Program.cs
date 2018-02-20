using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunc
{
    public delegate int BeregnDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregner(1, 1, Plus);
            Console.WriteLine(res);
            res = Beregner(1, 1, Minus);
            Console.WriteLine(res);
            res = Beregner(5, 2, Divider);
            Console.WriteLine(res);
            res = Beregner(5, 2, Gange);
            Console.WriteLine(res);
        }

        public static int Beregner(int a, int b, BeregnDelegate function)
        {
            return function(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}

