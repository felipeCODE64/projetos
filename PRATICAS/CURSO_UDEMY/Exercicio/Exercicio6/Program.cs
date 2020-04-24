using Exercicio6.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            List<Contribuinte> contribuintes = new List<Contribuinte>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"DADOS DO CONTRIBUÍNTE #{i}");
                Console.Write("Pessoa Físical ou Jurídica (F/J): ");
                Char resp = Char.Parse(Console.ReadLine().ToLower());
                Console.Write("Nome do contribuinte: ");
                String nome = Console.ReadLine();
                Console.Write("Renda anual do contribuinte: ");
                Double rendaAnual = Double.Parse(Console.ReadLine());

                if (resp == 'f')
                {
                    Console.Write("Despesas com saúde: ");
                    Double despesaSaude = Double.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaFisica(nome, rendaAnual, despesaSaude));
                }
                else
                {
                    Console.Write("Quantidade de funcionarios: ");
                    int qtdfunc = int.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaJuridica(nome, rendaAnual, qtdfunc));
                }
            }
            Double SomaGeral = 0.0;
            foreach (Contribuinte contribuinte in contribuintes)
            {
                Double imposto = contribuinte.CalculaImposto();
                Console.WriteLine(contribuinte.Nome + " - " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                SomaGeral += imposto;
            }
            Console.WriteLine("TOTAL GERAL");
            Console.WriteLine(SomaGeral.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
