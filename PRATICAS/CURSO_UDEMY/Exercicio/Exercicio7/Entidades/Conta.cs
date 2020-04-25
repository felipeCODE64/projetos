using Exercicio7.Entidades.Exececoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Exercicio7.Entidades
{
    class Conta
    {
        public int Numero { get; set; }
        public String Titular { get; set; }
        public Double Saldo { get; set; }
        public Double LimiteSaque { get; set; }

        public Conta()
        {

        }
        public Conta(int numero, string titular, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(Double deposito)
        {
            if (deposito > 0)
            {
                Saldo += deposito;
            }
            else
            {
                throw new ExececaoConta("Depósito inicial não pode ser menor ou igual a zero.");
            }
            }
            public void Saque(Double saque)
            {
                if (saque > LimiteSaque)
                {
                    throw new ExececaoConta("Valor maior que o limite para saque");
                }
                if (saque > Saldo)
                {
                    throw new ExececaoConta("Valor maior que o Saldo");
                }

                Saldo -= saque;
            }
        public override string ToString()
        {
            return "Conta: " + Numero + " - " + Titular + " - Saldo da conta: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
