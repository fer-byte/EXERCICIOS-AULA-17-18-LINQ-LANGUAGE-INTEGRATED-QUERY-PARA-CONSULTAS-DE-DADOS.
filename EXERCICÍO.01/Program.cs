using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace ConsultaEmArrays
{
    class Program
    {
        static void Main(string[] args)
        {
                                    //1.CONSULTAS EM ARRAYS
            //Exercício: Crie um array de números inteiros. Use LINQ para encontrar todos
                        //os números pares e ordená-los em ordem crescente.

            // Array aplicado
            int[] numeros = { 10, 21, 4, 15, 8, 33, 2, 14 };

            // Usando o LINQ
            var numerosParesOrdenados = numeros.Where(n => n % 2 == 0).OrderBy(n => n);

            // Números pares ordenados
            Console.WriteLine("\n\n\n           Números pares ordenados em crescente:");
            foreach (var                                numero in numerosParesOrdenados)
            {
                Console.WriteLine(                          numero);
            }

            // Pausa do console aberto
            Console.ReadLine();
        }
    }
}

