using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace AgrupamentoComLINQ
{
                                    //4. AGRUPAMENTO COM LINQ
                //Crie uma lista de objetos representando produtos, cada um com um
                    //nome e uma categoria.Use LINQ para agrupar os produtos por categoria
                //e contar quantos produtos existem em cada categoria.

    class Program
    {
        // Definição da classe Produto
        class Produto
        {
            public string Nome { get; set; }
            public string Categoria { get; set; }
        }

        static void Main(string[] args)
        {
            // Criação de uma lista de produtos
            List<Produto> produtos = new List<Produto>
            {
                new Produto { Nome = "Notebook", Categoria = "Eletrônicos" },
                new Produto { Nome = "Smartphone", Categoria = "Eletrônicos" },
                new Produto { Nome = "Teclado", Categoria = "Acessórios" },
                new Produto { Nome = "Mouse", Categoria = "Acessórios" },
                new Produto { Nome = "Geladeira", Categoria = "Eletrodomésticos" },
                new Produto { Nome = "Fogão", Categoria = "Eletrodomésticos" },
                new Produto { Nome = "Microondas", Categoria = "Eletrodomésticos" }
            };

            // Usando o LINQ para agrupar produtos por categoria e contar quantos produtos.
            var agrupamento = produtos.GroupBy(p => p.Categoria)
                                      .Select(g => new { Categoria = g.Key, Contagem = g.Count() });

            // Mostrando os resultados
            Console.WriteLine("\n\n\n                       Número de produtos por categoria:");
            foreach (var grupo in agrupamento)
            {
                Console.WriteLine($"\n  Categoria: {grupo.Categoria}, Quantidade: {grupo.Contagem}");
            }

            // Pausa para manter o console aberto
            Console.ReadLine();
        }
    }
}

