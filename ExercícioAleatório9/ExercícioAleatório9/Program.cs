using System;

namespace ExercícioAleatório9
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            bool checkA = false, checkB = false, checkC = false;
            Console.WriteLine("Entre com o primeiro lado do triangulo: ...");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo lado do triangulo: ...");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o terceiro lado do triangulo: ...");
            C = int.Parse(Console.ReadLine());

            if (A < (B + C))
            {
                checkA = true;
            }
        
            if (B < (A + C))
            {
                checkB = true;
            }
            
            if (C < (B + A))
            {
                checkC = true;
            }

            if (checkA && checkB && checkC)
            {
                Console.WriteLine("Triângulo Possível");
            }
            else
            {
                Console.WriteLine("Triângulo impossível.");
            }
        }
    }
}
