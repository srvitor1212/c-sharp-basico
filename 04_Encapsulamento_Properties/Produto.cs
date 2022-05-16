

using System;
using System.Globalization;


namespace Course
{
    class Produto
    {
        //Atributos privados
        private string _nome;
        private double _preco;
        private int _quantidade;
        public string Modelo { get; set; } //Auto-Properties
        public string Tamanho { get; private set; } //Auto-Properties

        //Construtor
        public Produto(string nome, double preco, int qtd)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = qtd;
        }

        //Sobrecarga
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }

        //Properties
        public string Nome
        {
            get { return _nome; }
            set
            {
                if ( (value != null) && (value.Length > 1) ) {
                    this._nome = value;
                } else {
                    Console.WriteLine(">>ERRO=Nome não atente aos requisitos!");
                }
            }
        }

        // -----------------------------------------------------------
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}