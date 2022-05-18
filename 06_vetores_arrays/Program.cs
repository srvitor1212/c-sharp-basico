
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Armazenandos stucts, nesse caso um double */
            int n = 10;
            double[] vetor = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + ": " + vetor[i]);
            }

            /* Aramzenando objetos */
            n = 4;
            Produto[] vect = new Produto[n];
            Console.WriteLine(">>>> Instânciando os objetos");
            for (int i=0; i < n; i++)
            {
                //vect[i] = new Produto(); //Pode ser vazio também
                vect[i] = new Produto{Nome = "O produto " + i, Preco = 100+i};
                Console.WriteLine("idx[" + i + "]= " + vect[i]);
            }
        }
    }
}