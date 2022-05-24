
namespace Curso
{
    class Calc
    {
        public static void Triplica (int v)
        {
            v = v * 3;
        }
        public static void TriplicaRef (ref int v)
        {
            v = v * 3;
        }

        public static void TriplicaOut(int origem, out int res)
        {
            res = origem * 3;
        }
    }
}