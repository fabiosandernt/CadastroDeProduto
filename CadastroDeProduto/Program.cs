using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto;
            produto = new Produto();

            Console.WriteLine("Entre com dados do Produto: Nome, Preço e Quantidade:");
            produto.Nome = Console.ReadLine();
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do Produto: " + produto);
            Console.WriteLine("Digite quantidade a adicionar no estoque:");
            //int quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do Produto: " + produto);
            Console.WriteLine("Digite quantidade a remover no estoque:");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do Produto: " + produto);
        }


    }
}
