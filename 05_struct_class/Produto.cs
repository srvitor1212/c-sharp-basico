using System;
namespace Curso
{
    class Produto
    {

        public string Nome;
        public double Valor;
        public int Codigo;

        public Produto(string nome, double valor, int codigo)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Codigo = codigo;
        }

        public override string ToString()
        {
            return Nome + ", " + Valor + ", " + Codigo;
        }

    }
}