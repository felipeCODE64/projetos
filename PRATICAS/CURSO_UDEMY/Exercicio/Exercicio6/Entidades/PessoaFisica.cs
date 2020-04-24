using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Exercicio6.Entidades
{
    class PessoaFisica : Contribuinte
    {
        public Double GastoSaude { get; set; }
        public PessoaFisica()
        {
        }
        public PessoaFisica(String nome, Double rendaAnual, Double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalculaImposto()
        {
            if (RendaAnual < 20000.00)
            {
                return RendaAnual * 0.15 - GastoSaude * 0.50;
            }
            else
            {
                return RendaAnual * 0.25 - GastoSaude * 0.50; ;
            }
        }

    }




}
