using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H.W._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string dr = "D:/";
            DirectoryInfo diirectory = new DirectoryInfo(dr);
            foreach (var s in diirectory.GetDirectories())
            {
                Console.WriteLine(s.Name);
                Console.WriteLine("Подкаталоги");
                foreach (var d in s.GetDirectories())
                {
                    Console.WriteLine(d.Name);
                }


            }
            Console.ReadKey();
        }
    }
}
