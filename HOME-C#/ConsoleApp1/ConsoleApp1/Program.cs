using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Metin", "Eldar", "Rauf", "Cavid", "Qadir", "Elxan" };
            int count = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i][0] == 'E')
                {
                    Console.WriteLine(names[i]);
                    count++;
                }
            }

            Console.WriteLine("Count: "+ count);
        }
    }
}
