﻿using System.Globalization;

namespace ExercicioFixacaoHeranca.Entidades {
    class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto() { }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        //aqui criamos um método com permissão para que as subclasses possam acessar e
        //modificar.
        public virtual string TabelaPreco() {
            return "Nome: " + Nome
                    + "Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture);
            
        }
    }
}
