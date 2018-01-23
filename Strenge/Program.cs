using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();
            string del = samletNavn.Substring(8,3);

            Console.WriteLine(del);
            System.Console.ReadKey();


        }
    }
}
