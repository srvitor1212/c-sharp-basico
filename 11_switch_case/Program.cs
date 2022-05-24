
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            ValidarAno(x);

            x = 6;
            ValidarAno(x);

            x = 9;
            ValidarAno(x);

            x = 10;
            ValidarAno(x);

            x = 11;
            ValidarAno(x);


        }

        static void ValidarAno(int nota)
        {
            switch (nota)
            {
                case < 5:
                    System.Console.WriteLine("Reprovou");
                    break;
                case < 7:
                    System.Console.WriteLine("Em recuperação");
                    break;
                case < 10:
                    System.Console.WriteLine("Passou de ano");
                    break;
                case 10:
                    System.Console.WriteLine("Nota 10");
                    break;
                default:
                    System.Console.WriteLine("Valor inválido");
                    break;
            }
        }
    }
}