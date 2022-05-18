using System;
namespace Curso 
{
    class Program {
        static void Main(string[] args) {
            /*
                Classes são ponteiro para a memória; Aceiram valores null
                Struct é o dado diretamente na memória;

                Produto p1;
                p1 = new Produto("TV", 900, 7);
                +================Memória===============+
                | Endereço           Dado em memória   |
                |+------Stack------+-------Heap------+ |
                ||                 |                 | |
                ||  p1=0x100358    | 0x100358=TV9007 | |
                ||                 |                 | |
                |+-----------------+-----------------+ |
                +======================================+
            */
            Produto p1, p2;
            p1 = new Produto("TV", 900, 7);
            Console.WriteLine(p1);
            p2 = p1;    //Aqui p1 e p2 apontam para o mesmo endereço de memória/mesmo objeto;
            p2.Valor = 2700;
            Console.WriteLine("p1=" + p1 + "| p2=" + p2);

            /*
                São structus: double, int, string;
                Struct é mais performático que uma classe
            */
            int i1, i2;     //Faz uma cópia mas guarda em endereços de memória diferentes
            i1 = 10;
            i2 = i1;
            Console.WriteLine(i1 + " / " + i2);
            i2 += 2;
            Console.WriteLine(i1 + " / " + i2);

            MeuStruct ms1, ms2;
            ms1.X = 100;
            ms1.Y = 200;
            ms2 = ms1;
            Console.WriteLine(ms1 + " - " + ms2);            
            ms2.Y=400;
            Console.WriteLine(ms1 + " - " + ms2);
        }
    }
}