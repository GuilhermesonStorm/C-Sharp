using System;

namespace ExercicioAleatorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Entre com um número: ...");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Número par");
            }
            else
            {
                Console.WriteLine("Número ímpar");
            }
        }
    }
}
