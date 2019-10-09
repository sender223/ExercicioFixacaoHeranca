using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixacaoHeranca.Entidades;

namespace ExercicioFixacaoHeranca {
    class Program {
        static void Main(string[] args) {
            //criando uma lista para os produtos
            List<Produto> lista = new List<Produto>();
            
            Console.Write("Entre com a Quantidade de produtos: " );
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qnt; i++) {
                Console.WriteLine($"Dados do {i}º Produto: ");
                //tipo char para ser somente 1 caracter
                Console.Write("Comum, Usado ou Importado (c, u, i) ?: ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //se o tipo for igual a i, acrescente na lista dos produtos o nome, preco, e a taxa
                if (tipo == 'i') {
                    Console.WriteLine("Valor da Taxa da Alfandega");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, taxa));
                }
                //se o tipo for igual a u, acrescentar  na lista dos produtos o nome preco e a dataFabricacao
                else if (tipo == 'u') {
                    Console.Write("Data de Fabricação (DD/MM/YYYY): ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }//se não, somente adicionar o nome e o preço
                else {
                    lista.Add(new Produto(nome, preco));
                }                
            }
            Console.WriteLine();
            //para cada produto imprimir a tabela de preço
            Console.WriteLine("Tabela de Preços: ");
            foreach(Produto pro in lista) {                
                Console.WriteLine(pro.TabelaPreco());
            }                        
        }
    }
}
