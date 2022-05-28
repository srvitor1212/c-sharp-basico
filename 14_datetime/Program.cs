
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


            //---------------------------------------------------
            System.Console.WriteLine("=================== datetime kind");
            DateTime d1 = new DateTime(2022, 12, 31, 13, 54, 49, DateTimeKind.Local); //do computador
            DateTime d2 = new DateTime(2022, 12, 31, 13, 54, 49, DateTimeKind.Utc); //hora do GMT (greenwich mean time)
            DateTime d3 = new DateTime(2022, 12, 31, 13, 54, 49);
            System.Console.WriteLine("d1..: " + d1);
            System.Console.WriteLine("d2..: " + d2);
            System.Console.WriteLine("d3..: " + d3);

            System.Console.WriteLine("=== d1");
            System.Console.WriteLine("kind.....: " + d1.Kind);
            System.Console.WriteLine("to local.: " + d1.ToLocalTime());
            System.Console.WriteLine("to utc...: " + d1.ToUniversalTime()); //adicionar 3 horas pois o brasil é GMT-3

            System.Console.WriteLine("=== d2");
            System.Console.WriteLine("kind.....: " + d2.Kind);
            System.Console.WriteLine("to local.: " + d2.ToLocalTime());
            System.Console.WriteLine("to utc...: " + d2.ToUniversalTime());

            System.Console.WriteLine("=== d2");
            System.Console.WriteLine("kind.....: " + d3.Kind);
            System.Console.WriteLine("to local.: " + d3.ToLocalTime());
            System.Console.WriteLine("to utc...: " + d3.ToUniversalTime());            

        }
    }
}