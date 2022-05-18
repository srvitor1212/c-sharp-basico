using System;
namespace Curso
{
    struct MeuStruct
    {

        public int X;
        public int Y;

        public override string ToString()
        {
            return "[" + X + " / " + Y + "]";
        }

    }
}