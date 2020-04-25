using Exercicio7.Entidades;
using Exercicio7.Entidades.Exececoes;
using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            String titular = Console.ReadLine();
            Console.Write("Limite de saque da conta: ");
            Double limiteSaque = Double.Parse(Console.ReadLine());

            Conta conta = new Conta(numConta, titular, limiteSaque);

            Console.Write("Valor para depósito inicial: ");
            Double deposito = Double.Parse(Console.ReadLine());

            try
            {
                conta.Deposito(deposito);

                Console.WriteLine("");
                Console.WriteLine(conta);
            }
            catch (ExececaoConta e)
            {
                Console.WriteLine("Erro!! " + e.Message);
            }

            Console.ReadLine();
            Console.Clear();

            Console.Write("Valor para saque: ");
            Double saque = Double.Parse(Console.ReadLine());

            try
            {
                conta.Saque(saque);

                Console.WriteLine("");
                Console.WriteLine(conta);
            }
            catch (ExececaoConta e)
            {
                Console.WriteLine("Erro!! " + e.Message);
            }
        }
    }
}
