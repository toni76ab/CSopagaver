using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningApp1
{
    class Terning
    {

        public int Værdi;
        private static System.Random rnd = new Random();



        public Terning()
        {
            this.Værdi = 1;
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Ryst(bool snyd)
        {
            if (snyd)
            {
                this.Værdi = 6;
            }
            else
            {
                Ryst();
            }

     
        }
    }

    public class Bæger
    {
        Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }
        }

        public void skriv()
        {
            Console.WriteLine("Bærger");
            for (int i = 0; i < 5; i++)
            {
                terninger[i].Skriv();
            }
        }
    }
}

