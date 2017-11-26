using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnExcellentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here comes the changes!");

            Console.WriteLine("We need another line added here - this is first change from laptop");

            FeatureFluff();

            Console.ReadKey();
        }


        public static void FeatureFluff()
        {
            Console.WriteLine("This is a killer app");
        }
    }
}
