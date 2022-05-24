using System;
namespace Curso 
{
    class Program {
        static void Main(string[] args) {



            Console.WriteLine("===================================================================================================================");
            Console.WriteLine("========== Básicos");
            /*
                int: -2.147.483.648 a 2.147.483.647, Inteiro assinado de 32 bits	System.Int32
                double - 
                char - 
                string - 
                bool - 
            */
            Console.WriteLine("========== Valores Nulos (null, nullable)");
            Nullable<double> x = null;
            double? y = null;
            if (x == null && y == null) {
                //Se y for null, recebe 0.75
                double a = y ?? 0.75;
                Console.WriteLine("x e y são nulos - a=" + a);
            }



            Console.WriteLine("===================================================================================================================");
            Console.WriteLine("========== Números Inteiros");
            /*
                palavra-chave/tipo C#	Intervalo	Tamanho	Tipo .NET

                sbyte	-128 a 127	Inteiro de 8 bits com sinal	            System.SByte
                byte	0 a 255	Inteiro de 8 bits sem sinal	                System.Byte

                short	-32.768 a 32.767	Inteiro de 16 bits com sinal	System.Int16
                ushort	0 a 65.535	Inteiro de 16 bits sem sinal	        System.UInt16

                int	-2.147.483.648 a 2.147.483.647	Inteiro assinado de 32 bits	    System.Int32
                uint	0 a 4.294.967.295	Inteiro de 32 bits sem sinal	        System.UInt32

                long	-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807	Inteiro assinado de 64 bits	    System.Int64
                ulong	0 a 18.446.744.073.709.551.615	Inteiro de 64 bits sem sinal	                        System.UInt64

                nint	Depende da plataforma	Inteiro com sinal de 32 bits ou 64 bits	    System.IntPtr
                nuint	Depende da plataforma	Inteiro sem sinal de 32 bits ou 64 bits     System.UIntPtr

                ------------------
                decimal: sem nenhum prefixo
                hexadecimal: com o 0x ou 0X prefixo
                binário: com o 0b prefixo ( 0B disponível em C# 7.0 e posterior)
                Exemplo:
                    var decimalLiteral = 42;
                    var hexLiteral = 0x2A;
                    var binaryLiteral = 0b_0010_1010;
            */



            Console.WriteLine("===================================================================================================================");
            Console.WriteLine("========== Números Flutuantes");
            
            float xfloat = 0.123456789F;                //sufixo f ou F        
            Console.WriteLine("float=" + xfloat);       //Resultado: float=0,12345679
            xfloat = 123.123456789f;
            Console.WriteLine("float=" + xfloat);       //Resultado: float=123,12346

            double xdouble = 0.12345678901234567890;    //sufixo d, D ou sem sufixo
            Console.WriteLine("double=" + xdouble);     //Resultado: double=0,12345678901234568
            xdouble = 123.12345678901234567890;
            Console.WriteLine("double=" + xdouble);     //Resultado: double=123,12345678901235

            decimal xdecimal = 0.111111111122222222221234567890m;   //sufixo m ou M
            Console.WriteLine("xdecimal=" + xdecimal);              //Resultado: xdecimal=0,1111111111222222222212345679
            xdecimal = 123.111111111122222222221234567890m;
            Console.WriteLine("xdecimal=" + xdecimal);              //Resultado: xdecimal=123,11111111112222222222123457

            /*
                palavra-chave/tipo C#	Intervalo aproximado	Precisão	Tamanho	Tipo .NET
                float	±1,5 x 10−45 para ±3,4 x 1038	        ~6 a 9 dígitos	4 bytes	        System.Single
                double	±5.0 × 10−324 to ±1.7 × 10308	        ~15 a 17 dígitos	8 bytes	    System.Double
                decimal	±1,0 x 10-28 para ±7,9228 x 1028	    28 a 29 dígitos	16 bytes	System.Decimal
            */
        }
    }
}