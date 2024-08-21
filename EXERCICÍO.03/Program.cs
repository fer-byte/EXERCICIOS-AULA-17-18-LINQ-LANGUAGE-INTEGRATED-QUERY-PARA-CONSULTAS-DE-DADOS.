using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultaEmDicionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dicionário onde a chave é um número e o valor é uma string
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" },
                { 5, "Five" },
                { 6, "Six" }
            };

            // Uso do LINQ,onde a letra "e" e ordená-las pela chave
            var resultados = dict.Where(entry => entry.Value.Contains("e"))
                                 .OrderBy(entry => entry.Key);

            // Entradas filtradas e ordenadas
            Console.WriteLine("\n\n\n           Entradas onde o valor contém a letra 'e', ordenadas pela chave:");
            foreach (var entrada in resultados)
            {
                Console.WriteLine($"\n  Chave: {entrada.Key}, Valor: {entrada.Value}");
            }

            // Pausa para manter o console aberto
            Console.ReadLine();
        }
    }
}

