using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6.Entidades
{
    class PessoaJuridica : Contribuinte
    {
        public int QtdFunc { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica( String nome, Double rendaAnual, int qtdFunc) : base(nome, rendaAnual)
        {
            QtdFunc = qtdFunc;
        }

        public override double CalculaImposto()
        {
            if (QtdFunc > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
