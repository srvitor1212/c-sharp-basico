
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //É a quantidade de ticks desde 01/01/0001
            DateTime agora = DateTime.Now;
            System.Console.WriteLine(agora);
            System.Console.WriteLine(agora.Ticks);      //data em inteiro

            System.Console.WriteLine("-----");
            DateTime dataX = new DateTime(2022, 12, 31, 22, 55, 49, 500); //aaaa mm dd hh mm ss mm
            System.Console.WriteLine(dataX);
            System.Console.WriteLine(dataX.Ticks);

            System.Console.WriteLine("-----");
            DateTime data1 = DateTime.Today;
            System.Console.WriteLine(data1);

            DateTime data2 = DateTime.Parse("2022-08-15 22:05:58"); // converser automático o string em DateTime
            System.Console.WriteLine(data2);

            DateTime data3 = DateTime.Parse("25-11-1993 00:05:34");
            System.Console.WriteLine(data3);

            DateTime data4 = DateTime.ParseExact("2000-05-31", "yyyy-MM-dd", CultureInfo.InstalledUICulture); //formata manualmente
            System.Console.WriteLine(data4);

            if (data3 < agora) {
                System.Console.WriteLine("data3 menor que agora");
            }
            else {
                System.Console.WriteLine("não é");
            }

        }
    }
}