
namespace Curso
{
    class Somar
    {
        //public static int Soma(int[] valor) // também funciona, mas na hora de chamar tem uma usar: new int[] {}
        public static int Soma(params int[] valor)
        {
            int res = 0;
            for (int i = 0; i < valor.Length; i++)
            {
                res += valor[i];
            }

            return res;
        }
    }
}