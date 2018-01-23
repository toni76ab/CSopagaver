using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] månedsløn = {13000, 22000, 25000, 26000, 30000, 15000 };
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            double gns = sum / månedsløn.Length;

            for(int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            Console.WriteLine("");

            //Array.Sort(månedsløn);
            System.Array.Sort(månedsløn);

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            Console.WriteLine("");

            månedsløn.Reverse();

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            Console.WriteLine("");

            Console.WriteLine("Gennemsnit " + gns.ToString("N2"));
            //System.Console.Write("Press any key to continue . . . ");
            System.Console.ReadKey();

        }
    }
}
