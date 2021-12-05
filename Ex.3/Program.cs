using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dr_txt = "Ex.3/Ex.txt";
            using (StreamReader st = new StreamReader(dr_txt))
            {
                int num1 = 0;
                do
                {
                    ++num1;
                } while ((st.ReadLine())!=null);
                Console.WriteLine(num1);
            }
            Console.ReadKey();

        }
    }
}
