using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Entidades
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public Double ValorHora { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHora;
        }
           
    }

}
