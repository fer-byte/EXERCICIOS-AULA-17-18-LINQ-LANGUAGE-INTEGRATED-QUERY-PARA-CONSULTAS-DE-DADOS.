using System;
using System.Linq;

namespace FiltragemEProjecao
{
    class Program
    {
                                        //5. FILTRAGEM E PROJEÇÃO
                //Crie uma lista de números inteiros.Use LINQ para encontrar todos
                //os números maiores que 10, multiplicar cada número por 2
                //e retornar a lista resultante.

        static void Main(string[] args)
        {
            // Criação de uma lista de números inteiros
            List<int> numeros = new List<int> { 5, 12, 7, 20, 3, 15, 8, 25 };

            // Uso do LINQ para encontrar todos os números maiores que 10, multiplicar por 2 e retornar a lista resultante
            var numerosProcessados = numeros.Where(n => n > 10)
                                            .Select(n => n * 2)
                                            .ToList();

            // Exibindo os números processados
            Console.WriteLine("\n\n\n               Números maiores que 10 multiplicados por 2:");
            foreach (var numero in numerosProcessados)
            {
                Console.WriteLine(numero);
            }

            // Pausa para manter o console aberto
            Console.ReadLine();
        }
    }
}

