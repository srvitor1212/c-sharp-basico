
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //time span é um intervalo de tempo
            //é a quantidade de ticks entre X e Y
            // 1 tick é 100 nano segundos

            TimeSpan t1 = new TimeSpan(0, 1, 30); //hh mm ss
            System.Console.WriteLine(t1);
            System.Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan(1, 2, 11, 21, 321); //dia hh mm ss mmm
            System.Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.FromDays(1.5); //permite fracionar
            System.Console.WriteLine(t3);
        }
    }
}