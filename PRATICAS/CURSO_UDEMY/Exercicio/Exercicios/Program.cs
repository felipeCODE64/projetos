using Exercicios.Entidades;
using Exercicios.Entidades.Enums;
using System;


namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do departamento: ");
            string nomeDep = Console.ReadLine();
            Console.Write("Nome do funcipnário: ");
            string nomeFunc = Console.ReadLine();
            Console.Write("Nível do funcionário: (Junior/Pleno/Senior)");
            NivelFuncionario nivel = Enum.Parse<NivelFuncionario>(Console.ReadLine());
            Console.Write("Salário Base: ");
            Double salarioBase = Double.Parse(Console.ReadLine());

            Departamento departamento = new Departamento(nomeDep);
            Funcionario funcionario = new Funcionario(nomeFunc, nivel, salarioBase, departamento);

            Console.Write("Quantos contratos para o funcionário: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Contrato #" + i);
                Console.WriteLine("Data do contrato (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor da hora no contrato: ");
                Double valorHora = Double.Parse(Console.ReadLine());
                Console.Write("Quantidade de horas no contrato: ");
                int horas = int.Parse(Console.ReadLine());

                Contrato contrato = new Contrato(data, valorHora, horas);
                funcionario.InserirContrato(contrato);
            }

            Console.Write("Qual mês e ano para calcular salário: ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine("------------------");
            Console.WriteLine("Funcionário: " + funcionario.Nome);
            Console.WriteLine("Departamento: " + funcionario.Departamento.Nome);
            Console.WriteLine("Salario total em " + mesAno + ": " + funcionario.Ganho(mes, ano));
        }
    }
}
