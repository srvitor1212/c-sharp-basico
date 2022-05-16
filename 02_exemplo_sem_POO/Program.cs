

using System;
using System.Globalization; // Para poder usar 1.23


namespace Curso 
{
    class Program {
        static void Main(string[] args) {

            double x1, x2, x3, y1, y2, y3;

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x1 + x2 + x3) / 2.0;
            double areaX = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3) );

            p = (y1 + y2 + y3) / 2.0;
            double areaY = Math.Sqrt(p * (p - y1) * (p - y2) * (p - y3) );

            Console.WriteLine("Área de X = " + areaX.ToString("F4"), CultureInfo.InvariantCulture );
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"), CultureInfo.InvariantCulture );

            if (areaX > areaY) {
                Console.WriteLine("X é maior");
            } else {
                Console.WriteLine("Y é maior");
            }
        }
    }
}