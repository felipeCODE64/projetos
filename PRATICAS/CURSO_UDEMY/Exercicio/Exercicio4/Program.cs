using Exercicio4.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> ListaFuncionario = new List<Funcionario>();

            Console.Write("Quantos funcionário? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do funcionário #{i}");
                Console.Write("O funcionário é terceirizado? (y/n)");
                char resp = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Quantidade Horas: ");
                int hora = int.Parse(Console.ReadLine());
                Console.Write("Valor da hora: ");
                double valorHora = double.Parse(Console.ReadLine());

                if (resp == 'S')
                {
                    Console.Write("Despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine());
                    ListaFuncionario.Add(new FuncionarioTerc(nome, hora, valorHora, despesaAdicional));
                }
                else
                {
                    ListaFuncionario.Add(new Funcionario(nome, hora, valorHora));
                }

                Console.WriteLine("RESUMO");
                foreach(Funcionario func in ListaFuncionario)
                {
                    Console.WriteLine(func.Nome + " - " + func.Pagamento().ToString("F2",CultureInfo.InvariantCulture));
                }


            }
        }
    }
}
