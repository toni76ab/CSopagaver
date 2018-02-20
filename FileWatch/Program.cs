using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            w.Changed += W_Changed;
            w.Deleted += W_Deleted;
            do { } while (true);

        }

        private static void W_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " was deleted");
        }

        private static void W_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " was changed");
        }
    }

}
