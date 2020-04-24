using Exercicio3.Entidades;
using Exercicio3.Entidades.Enums;
using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>TECLE ENTER PARA INICIAR O PEDIDO<<");
            Console.ReadLine();
            Console.Write("Nome do cliente: ");
            string nomeCLiente = Console.ReadLine();
            Console.Write("Email do cliente: ");
            string email = Console.ReadLine();
            Console.Write("data de nascimento do cliente (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Status do pedido: ");
            StatusOrcamento status = Enum.Parse<StatusOrcamento>(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCLiente, email, dataNascimento);
            Orcamento orcamento = new Orcamento(DateTime.Now, status, cliente);

            Console.Write("Quantidade de itens no pedido: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Item #{i}");
                Console.Write("Descrição produto: ");
                string descricaoProduto = Console.ReadLine();
                Console.Write("Valor do produto: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(descricaoProduto, valor);

                Console.Write("Quatidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItensOrcamento itensOrcamento = new ItensOrcamento(quantidade, valor, produto);

                orcamento.InserirItem(itensOrcamento);
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL ORCAMENTO:");
            Console.WriteLine(orcamento);
        }
    }
}
