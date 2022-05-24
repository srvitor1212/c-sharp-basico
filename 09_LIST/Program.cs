
using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Maneiras de se declarar
            */
            //Informa o tipo e o nome da variavel
            List<string> lista;
            lista = new List<string>(); //Cria a instância da lista

            //Criando e já instânciando
            List<string> lista01 = new List<string>();

            ////Criando, instânciando e inserindo valores
            List<string> lista02 = new List<string>() { "Vitor", "Julia", "Roberta" };


            /*
                Usando a lista
            */
            Console.WriteLine("======================================");
            ImprimeLista(lista02);

            // Adiciona ao final
            lista02.Add("Richard");
            ImprimeLista(lista02);

            //Insere na posição informada, empurra o resto
            lista02.Insert(0, "Vitor Vicente");
            ImprimeLista(lista02);

            //Último indice da lista
            Console.WriteLine("Count=" + lista02.Count);

            //Find na lista
            Console.WriteLine("Primeiro com R é.......: " + lista02.Find(x => x[0] == 'R'));
            Console.WriteLine("Último com R é.........: " + lista02.FindLast(x => x[0] == 'R'));

            //Find Index
            Console.WriteLine("Indice do primeiro R é.: " + lista02.FindIndex(x => x[0] == 'R'));
            Console.WriteLine("Indice do último R é...: " + lista02.FindLastIndex(x => x[0] == 'R'));

            //Encontrar todos que o tamanho é 5
            List<string> res = lista02.FindAll(x => x.Length == 5);
            ImprimeLista(res);
        }

        static void ImprimeLista(List<string> lst)
        {
            Console.WriteLine("=== ImprimeLista ===");
            foreach (string l in lst)
                Console.WriteLine("[" + lst.IndexOf(l) +"]" + l);
        }
    }
}