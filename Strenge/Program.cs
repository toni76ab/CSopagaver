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
            string del = samletNavn.Substring(7,4);

            string[] navne = samletNavn.Split(' ');
            for (int i = 0; i < navne.Length; i++)
                Console.WriteLine(navne[i]);

            Console.WriteLine(del);
            Console.WriteLine(fornavn + "\r\n\t" + efternavn);
            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
            System.Console.ReadKey();


        }
    }
}
