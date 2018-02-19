using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogNlog
{
    class Program
    {

        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Debug("APP Start");
       
        }

        static void test1(int i, int x)
        {
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
        }

        static void test2()
        {
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception)
            {

                //mángler log
            }
            
        }
           
    }
}
