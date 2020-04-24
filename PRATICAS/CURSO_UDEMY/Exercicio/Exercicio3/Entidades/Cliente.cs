using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entidades
{
    class Cliente
    {
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nomeCliente, string email, DateTime dataNascimento)
        {
            NomeCliente = nomeCliente;
            Email = email;
            DataNascimento = dataNascimento;
        }
        public override string ToString()
        {
            return NomeCliente
                + ", ("
                + DataNascimento.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
