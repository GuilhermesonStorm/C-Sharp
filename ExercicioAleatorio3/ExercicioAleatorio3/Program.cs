using System;
using System.Globalization;

namespace ExercicioAleatorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;
            double nota1, nota2, media, mediaideal = 7;

            Console.WriteLine("Entre com o nome do aluno: ...");
            nomeAluno = Console.ReadLine();
            do
            {
                Console.WriteLine("Entre com a primeira nota: ...");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } while (nota1 < 0);
            do
            {
                Console.WriteLine("Entre com a segunda nota: ...");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } while (nota2 < 0);

            media = (nota1 + nota2) / 2;

            if (media < mediaideal && media > 0)
            {
                Console.WriteLine($"O aluno {nomeAluno} não teve um bom aproveitamento em sua nota e está reprovado. Média: {media}");
            }
            else if (media >= mediaideal)
            {
                Console.WriteLine($"O aluno {nomeAluno} teve um bom aproveitamento em sua nota e está aprovado. Média: {media}");
            }

        }
    }
}
