using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;



            char valume = Convert.ToChar(Console.ReadLine());
            switch (valume)
            {
                case '+':
                    Console.WriteLine("Addition: " + add);
                    break;

                case '-':
                    Console.WriteLine("Subtraction: " + sub);
                    break;

                case '*':
                    Console.WriteLine("Multiplication: " + mul);
                    break;

                case '/':
                    Console.WriteLine("Division: " + div);
                    break;

                default:
                    Console.WriteLine("error");
                    break;

            }
        }
    }
}
