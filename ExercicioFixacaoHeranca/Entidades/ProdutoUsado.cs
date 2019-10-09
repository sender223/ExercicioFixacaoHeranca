using System;
using System.Globalization;

namespace ExercicioFixacaoHeranca.Entidades {
    class ProdutoUsado : Produto {

        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado() { }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) 
            : base(nome, preco) {
            DataFabricacao = dataFabricacao;
        }

        public override string ToString() {
            return Nome
                + " (used) $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + DataFabricacao.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
