using System;

namespace ExercícioAleatório6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, idade, dif, anoAtual = DateTime.Now.Year;
            do
            {
                Console.WriteLine("Entre com um ano válido.");
                ano = int.Parse(Console.ReadLine());
            } while (ano < 0 || ano > anoAtual);
            idade = anoAtual - ano;
            dif = 18 - idade;

            if (dif > 0)
            {
                Console.WriteLine($"Falta {dif} ano(s) para o alistamento.");
            }
            else if (dif < 0)
            {
                Console.WriteLine($"Passou-se {dif * -1} ano(s) do alistamento.");
            }
            
            
        }
    }
}
