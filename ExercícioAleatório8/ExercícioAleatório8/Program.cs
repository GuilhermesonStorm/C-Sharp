using System;

namespace ExercícioAleatório8
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double valor, valorTotal;
            Console.WriteLine("Entre com a distância do percurso desejado: (em Km)");
            distancia = int.Parse(Console.ReadLine());
            if (distancia <= 200 && distancia > 0)
            {
                valor = 0.5;
                valorTotal = distancia * valor;
                Console.WriteLine($"A distância é de: {distancia} Km.");
                Console.WriteLine($"O valor do percurso será: {valorTotal}");
            }
            else if (distancia > 200)
            {
                valor = 0.45;
                valorTotal = distancia * valor;
                Console.WriteLine($"A distância é de: {distancia} Km.");
                Console.WriteLine($"O valor do percurso será: {valorTotal}");
            }
            else
            {
                Console.WriteLine("Distância inválida.");
            }
        }
    }
}
