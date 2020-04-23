using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entidades
{
    class Produto
    {
        public string Descricao { get; set; }
        public double ValorItem { get; set; }

        public Produto()
        {
        }

        public Produto(string descricao, double valorItem)
        {
            Descricao = descricao;
            ValorItem = valorItem;
        }
    }
}
