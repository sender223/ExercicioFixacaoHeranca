using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixacaoHeranca.Entidades;

namespace ExercicioFixacaoHeranca {
    class Program {
        static void Main(string[] args) {

            List<Produto> lista = new List<Produto>();

            Console.Write("Entre com a Quantidade de produtos: " );
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qnt; i++) {
                Console.WriteLine($"Dados do {i}º Produto: ");
                Console.Write("Comum, Usado ou Importado (c, u, i) ?: ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == 'i') {
                    Console.WriteLine("Valor da Taxa da Alfandega");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, taxa));
                }
                else if (tipo == 'u') {
                    Console.Write("Data de Fabricação (DD/MM/YYYY): ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                else {
                    lista.Add(new Produto(nome, preco));
                }                
            }
            Console.WriteLine();
            Console.WriteLine("Tabela de Preços: ");
            foreach(Produto pro in lista) {                
                Console.WriteLine(pro.TabelaPreco());
            }                        
        }
    }
}
