using System;
using System.Globalization;

namespace ExercicioFixacaoHeranca.Entidades {
    class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto() { }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public virtual string TabelaPreco() {
            return "Nome: " + Nome
                    + "Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture);
            
        }
    }
}
