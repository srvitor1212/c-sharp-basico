

using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleta dos dados de cadastro
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");            
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            Console.Write("Quantidade no estoque: ");            
            int qtd = int.Parse(Console.ReadLine());

            //Instância o objeto
            Produto p = new Produto(nome, preco, qtd);
            //Produto p = new Produto(nome, preco); //usando a sobrecarga
            /*
            //Nesse tipo  não preisa declarar construtores na classe
            Produto p = new Produto() {
                Nome = "TV",
                Preco = 2900.99,
                Quantidade = 10
            };
            */

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            
            //Adicionar ao estoque
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            
            //Remover do estoque
            Console.Write("Digite o número de produtos a ser removido do estoque: ");            
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            
            //Mostro o objeto
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}