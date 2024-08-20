using System;
using System.Linq;

namespace ConsultaEmListas
{
    class Program
    {
                                    //2. CONSULTAS EM LISTAS
                //Crie uma lista de strings representando nomes de pessoas.Use
                    //LINQ para encontrar nomes que comecem com a letra "A"
                    //e ordene-os em ordem decrescente.


        static void Main(string[] args)
        {
            // Lista de strings representando nomes de pessoas
            List<string> nomes = new List<string> { "\n\n\n         Alice", "André", "Bruno", "Ana", "Carlos", "Amanda" };

            // Uso do LINQ para encontrar nomes que começam com "A"
            var nomesComAOrdenados = nomes.Where(n => n.StartsWith("A")).OrderByDescending(n => n);

            // Nomes que começam com a letra "A" em ordem decrescente
            Console.WriteLine("\n\n\n                           Nomes que começam com 'A' ordenados em ordem decrescente:");
            foreach (var nome in nomesComAOrdenados)
            {
                Console.WriteLine(nome);
            }

            // Pausa para manter o console aberto
            Console.ReadLine();
        }
    }
}

