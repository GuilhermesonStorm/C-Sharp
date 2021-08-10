using System;

namespace ExercícioAleatório7
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            double valor, valorTotal, descM = 0.05, descF = 0.13;

            Console.WriteLine("Entre com um sexo: (M = Masculino; F = Feminino) ...");
            sexo = char.Parse(Console.ReadLine());

            if (sexo == 'f')
            {

                Console.WriteLine("Sexo feminino.");
                Console.WriteLine("Entre com o valor da compra: ...");
                valor = double.Parse(Console.ReadLine());
                valorTotal = valor - (valor * descF);
                Console.WriteLine($"O valor total com desconto é: R$ {valorTotal}");
            }
            else if (sexo == 'm')
            {
                Console.WriteLine("Sexo masculino.");
                Console.WriteLine("Entre com o valor da compra: ...");
                valor = double.Parse(Console.ReadLine());
                valorTotal = valor - (valor * descM);
                Console.WriteLine($"O valor total com desconto é: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
