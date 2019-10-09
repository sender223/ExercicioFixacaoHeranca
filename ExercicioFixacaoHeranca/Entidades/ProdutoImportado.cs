using System.Globalization;

namespace ExercicioFixacaoHeranca.Entidades {
    //aqui importamos a superclasse Produto para herdar suas propriedades.
    class ProdutoImportado : Produto {

        public double TaxaAlfandega { get; set; }

        public ProdutoImportado() { }
        //aqui fizemos um construtor com os atributos da superclasse Produto
        //usando o ": base" para a importação.
        public ProdutoImportado(string nome, double preco, double taxaAlfandega) 
            :base(nome, preco) {
            TaxaAlfandega = taxaAlfandega;
        }

        public double PrecoTotal() {
            return Preco + TaxaAlfandega;
        }
        //aqui Chamamos o metodo da superclasse Produto e com a sobreposição, customizamos
        //as frases para atender a subclasse ProdutoImportado.
        public override string TabelaPreco() {
            return Nome
                + " $ "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
