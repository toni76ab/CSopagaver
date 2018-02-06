using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "Nielsen", Fornavn = "Torben" };
            Elev e = new Elev { Efternavn = "Vejmann", Fornavn = "Jens", KlasseLokale = "B12" };
            Instruktør i = new Instruktør { Efternavn = "Dibbermann", Fornavn = "George", NøgleId = 32 };
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(e.FuldtNavn());
            Console.WriteLine(i.FuldtNavn());

        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }

        public class Elev : Person
        {
            public string KlasseLokale { get; set; }
        }

        public class Instruktør : Person
        {
            public int NøgleId { get; set; }
        }
    
}
