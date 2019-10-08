using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoHeranca.Entidades {
    class ProdutoImportado : Produto {

        public double TaxaAlfandega { get; set; }

        public ProdutoImportado() { }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) :base(nome, preco) {
            TaxaAlfandega = taxaAlfandega;
        }



    }
}
