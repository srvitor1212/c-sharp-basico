
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] {"Vitor", "Maria", "Juliana"};

            foreach (string v in vetor)
            {
                Console.WriteLine(v);
            }
        }
    }
}