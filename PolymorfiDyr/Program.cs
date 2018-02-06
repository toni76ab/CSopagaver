using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorfiDyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }
            Console.WriteLine(1 % 3);
            Console.WriteLine(2 % 3);
            Console.WriteLine(3 % 3);
            Console.WriteLine(4 % 3);
            Console.WriteLine(5 % 3);
            Console.WriteLine(6 % 3);
        }
    }

    class Dyr
    {
        static System.Random rnd = new Random();
        public string Navn { get; set; }
        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navne.Length);
            int tester = index % 2;

            //switch (tester)
            //{
            //    case 0:
            //        return new Dyr() { Navn = navne[index] };
            //    case 1:
            //        return new Hund() { Navn = navne[index]};
            //    case 2:
            //        return new Kat() { Navn = navne[index] };
            //}

            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };

            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }


        }

    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + Navn);
        }

    }

    class Kat : Dyr
    {   public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + Navn);
        }
    }
}
