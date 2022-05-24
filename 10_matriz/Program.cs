
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,,] matriz = new double[22, 3, 2];       //linha, coluna
            Console.WriteLine(matriz.Length);               //Total de células
            Console.WriteLine(matriz.Rank);                 //Dimensões

            Console.WriteLine("---");
            Console.WriteLine(matriz.GetLength(0));         //Imprime o tamanho de cada dimensão
            Console.WriteLine(matriz.GetLength(1));
            Console.WriteLine(matriz.GetLength(2));

            Console.WriteLine("--- Exercicio ---");
            int tamanho = 3;
            int[,] tabela = new int[tamanho, tamanho];
            Random randNum = new Random();

            //Linha
            for (int l = 0; l < tamanho; l++)
            {
                //Coluna
                for (int c = 0; c < tamanho; c++)
                {
                    tabela[l,c] = randNum.Next();
                }
            }

            //Linha
            for (int l = 0; l < tamanho; l++)
            {
                //Coluna
                for (int c = 0; c < tamanho; c++)
                {
                    Console.Write(" |" + l + "-" + c + ": " + tabela[l,c]);
                }
                Console.WriteLine("");
            }
        }
    }
}