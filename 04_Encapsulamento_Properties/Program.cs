

using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.99, 10);
            Console.WriteLine(p);
            
            p.Nome = "TV UHD 4K"; //usando a propertie
            Console.WriteLine(p);

            p.Nome = "T"; //não permite menos de 1 na propertie
            Console.WriteLine(p);

            Console.WriteLine("---------------------------");
            p.Modelo = "TV de LED";
            //p.Tamanho = "190x80"; //Não permite por ser private
            Console.WriteLine("Modelo=" + p.Modelo + " Tamanho=" + p.Tamanho);
            Console.WriteLine(p);

            //Console.WriteLine(p._nome); //Como é private não deixa fazer isso
            
        }
    }
}