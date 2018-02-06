using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());

        }
    }

    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            return this.Next(1, 800) < 350;
        }
    }
 }
