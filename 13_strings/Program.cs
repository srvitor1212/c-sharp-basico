
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "       começo abcde FGHIJ ABC abc DFGH       fim  ";
            System.Console.WriteLine("original..........: [" + original + "]");

            string str = original.ToUpper();
            System.Console.WriteLine("ToUpper...........: [" + str + "]");

            str = original.Trim();
            System.Console.WriteLine("Trim..............: [" + str + "]");

            int idx = original.IndexOf("BC");
            System.Console.WriteLine("IndexOf(\"BC\").....: [" + idx + "]");

            str = original.Substring(10);
            System.Console.WriteLine("Substring(10).....: [" + str + "]");

            str = original.Substring(10,4);
            System.Console.WriteLine("Substring(10,4)...: [" + str + "]");

            str = original.Replace("a","X");
            System.Console.WriteLine("Replace(\"a\", \"X\").: [" + str + "]");

            System.Console.WriteLine(string.IsNullOrEmpty(original));
            System.Console.WriteLine(string.IsNullOrWhiteSpace(original));

            string linha = "empresa, filia, pedido, cliente, preço, total";
            string[] csv = linha.Split(',');
            System.Console.WriteLine("csv: " + csv[0] + csv[1] + csv[2] + csv[3] + csv[4] + csv[5]);
        }
    }
}