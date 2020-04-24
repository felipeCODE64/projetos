using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Entidades
{
    class FuncionarioTerc : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerc(string nome, int horas, double valorHora, double despesaAdicional) : base(nome, horas,valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
