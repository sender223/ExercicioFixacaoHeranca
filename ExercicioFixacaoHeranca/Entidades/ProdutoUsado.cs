using System;
using System.Globalization;

namespace ExercicioFixacaoHeranca.Entidades {
    //aqui importamos a superclasse Produto para herdar suas propriedades.
    class ProdutoUsado : Produto {

        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado() { }
        //aqui fizemos um construtor com os atributos da superclasse Produto
        //usando o ": base" para a importação.
        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) 
            : base(nome, preco) {
            DataFabricacao = dataFabricacao;
        }
        //aqui Chamamos o metodo da superclasse Produto e com a sobreposição, customizamos
        //as frases para atender a subclasse ProdutoImportado.
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
