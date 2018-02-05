using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.efternavn = "Nielsen";
            p1.fornavn = "Torben";
            p1.fødselsår = 1976;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimerAlder());
            Console.ReadKey();
        }
    }

    class Person
    {
        public string fornavn;
        public string efternavn;
        public int fødselsår;

        public string FuldtNavn()
        {
            return $"{fornavn} {efternavn}";
        }

        public int EstimerAlder()
        {
            int år = DateTime.Now.Year;
            if (DateTime.Now.Month <= 2)
            {
                if (DateTime.Now.Day < 6)
                {
                    år = år - 1;
                }
            }
            return år - this.fødselsår;
        }

        public Person()
        {
            this.fornavn = "";
            this.efternavn = "";

        }

        public Person(string efternavn, string fornavn, int fødselsår)
        {
            this.fødselsår = fødselsår;
            this.fornavn = fornavn;
            this.efternavn = efternavn;
        }
        
            


    }
}
