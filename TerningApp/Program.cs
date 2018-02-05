using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TerningApp1.Terning t1 = new TerningApp1.Terning();
            t1.Skriv();
            t1.Værdi = 4;
            t1.Skriv();
            t1.Værdi = 8; //bør ikke kunne ske
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            for (int i = 0; i < 10; i++)
            {
                t1.Ryst();
                t1.Skriv();
            }

            TerningApp1.Terning t2 = new TerningApp1.Terning();

            for (int i = 0; i < length; i++)
            {
                TerningApp1.Bæger b = new TerningApp1.Bæger();
                b.skriv();
            }

        }
    }
}
