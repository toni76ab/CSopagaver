using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(10,4);
            //t.Grundlinje = 10;
            //t.Højde = 4;
            Console.WriteLine(t.Areal);


        }
    }

    public class Trekant
    {
        public int Grundlinje { get; set; }
        public int Højde { get; set; }

        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        public double Areal
        {
            get
            {
                return this.Grundlinje * this.Højde * 0.5;
            }
        }
    }
}
