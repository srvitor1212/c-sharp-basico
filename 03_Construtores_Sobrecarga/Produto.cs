

using System.Globalization;


namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor
        public Produto(string nome, double preco, int qtd) {
            this.Nome = nome; //não necessariamente precisa usar this
            this.Preco = preco;
            this.Quantidade = qtd;
        }

        //Sobrecarga
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //Se não colocar, o valor é 0
        }
        
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}