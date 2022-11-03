using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Metin", "Mireli", "Mehemmed", "Mahir", "Fazil", "Ferahim" };
            int count = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 5)
                {
                    Console.WriteLine("Names: "+ names[i]);
                    count++;
                }
            }
            Console.WriteLine("Count: "+ count);
        }
    }
}
