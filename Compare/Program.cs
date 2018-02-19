using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[3];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 6, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 5, Navn = "Anders" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
        }
    }
    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h = obj as Hund;
            if (h.Alder > this.Alder)
                return -1;
            if (h.Alder < this.Alder)
                return 1;
                return 0;
         
        }
    }
}
