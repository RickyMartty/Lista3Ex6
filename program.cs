using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int d, p, a, b;

            do
            {
                Console.Write("Digite um N° positivo:");
                p = int.Parse(Console.ReadLine());

                if (p > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nº Aceito.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("N° não foi aceito");
                }
                Console.ForegroundColor = ConsoleColor.White;
            } while (p < 0);

            Console.Write("Digite um N°:");
            a = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite um 2° N° maior que seu primeiro:");
                b = int.Parse(Console.ReadLine());
            } while (a > b);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Condição Aceita");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = b; i>= a; i--)
            {
                d = p * i;
                Console.WriteLine($"{p} x {i} = {d}");
            }
        }
    }
}
