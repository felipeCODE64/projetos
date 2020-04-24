using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6.Entidades
{
    abstract class Contribuinte
    {
        public String Nome { get; set; }
        public Double RendaAnual { get; set; }

        public Contribuinte()
        {

        }

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract Double CalculaImposto();
 
    }
}
