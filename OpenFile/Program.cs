using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader stream = System.IO.File.OpenText("X:\\dyrenavne.txt"))
                while (stream.Peek() != -1)
                {
                    var l = stream.ReadLine();
                    Console.WriteLine(l);
                }
          
        }
    }

    
}
