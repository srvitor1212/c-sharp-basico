
namespace Curso
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return "Nome: " + this.Nome +
                   ", R$ " + this.Preco;
        }
    }
}