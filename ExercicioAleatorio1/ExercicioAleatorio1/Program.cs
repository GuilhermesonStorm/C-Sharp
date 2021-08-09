using System;

namespace ExercicioAleatorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidade, limite = 80 , multa;
            Console.WriteLine("Entre com uma velocidade: ...");
            velocidade = int.Parse(Console.ReadLine());
            if (velocidade > 80)
            {
                multa = (velocidade - limite) * 5;
                Console.WriteLine($"O valor da multa é de: R$ {multa}");
            }
            else if (velocidade < 0)
            {
                Console.WriteLine("Velocidade inválida");
            }
            else
            {
                Console.WriteLine("Veículo dentro do limite de velocidade");
            }

        }
    }
}
