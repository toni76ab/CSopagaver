using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beregnarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSorterArray(test);

            Console.WriteLine(res.sum);
            Console.WriteLine(res.gennemsnit);
            System.Console.ReadKey();

        }

        public static ArrayResultat BeregnOgSorterArray(int[] a)
        {
            ArrayResultat r;
            r.sum = 0;

            foreach (var item in a)
            {
                r.sum += item;
            }
            r.gennemsnit = r.sum / a.Length;
            Array.Sort(a);
            return r;
          
        }
    }

    struct ArrayResultat
    {
        public double sum;
        public double gennemsnit;
    }
}
