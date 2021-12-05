using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dr = "D:/Ex.2";
            string dr_txt = "D:/Ex.2/Log.txt";
            
            Random number = new Random();
            
            if (!Directory.Exists(dr))
            {
                Directory.CreateDirectory(dr);
            }
            if (!File.Exists(dr_txt))
            {
               File.Create(dr_txt);
            }
            using (StreamWriter sw = new StreamWriter(dr_txt, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.Write("{0} ",Convert.ToString(number.Next(-10, 10)));
                }
            }
            using (StreamReader sr = new StreamReader(dr_txt))
            {
                string[] arrayStream = sr.ReadToEnd().Split().Where(i=>!string.IsNullOrWhiteSpace(i)).ToArray();
                int sum = 0;
                Console.WriteLine("Значения с текстового файла:");
                for (int i = 0; i < arrayStream.Length; i++)
                {
                    int nub = Convert.ToInt32(arrayStream[i]);
                    sum += nub;
                    Console.Write("{0} ", nub);
                }
                Console.WriteLine("\nСумма чисел равна:\n{0}", sum);
            }
            
            Console.ReadKey();
        }
    }
}
