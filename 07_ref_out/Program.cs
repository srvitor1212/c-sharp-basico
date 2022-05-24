
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Modo \"padrão\"");
            int valor = 10;
            Calc.Triplica(valor);
            Console.WriteLine("valor=" + valor);

            Console.WriteLine("==== Usando REF"); //REF precisa inicializar a variável
            int valorREF = 10;
            Calc.TriplicaRef(ref valorREF);
            Console.WriteLine("valorREF=" + valorREF);


            Console.WriteLine("==== Usando OUT"); //OUT não precisa inicializar a variável
            int val = 10;
            int valTriplo;
            Calc.TriplicaOut(val, out valTriplo);
            Console.WriteLine("val=" + val + ", valTriplo=" + valTriplo);
        }
    }
}