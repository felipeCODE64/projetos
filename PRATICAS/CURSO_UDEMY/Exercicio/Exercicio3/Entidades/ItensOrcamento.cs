using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio3.Entidades
{
    class ItensOrcamento
    {
        public int Quantidade { get; set; }
        public double ValorItem { get; set; }
        public Produto Produto { get; set; }

        public ItensOrcamento()
        {
        }

        public ItensOrcamento(int quantidade, double valorItem, Produto produto)
        {
            Quantidade = quantidade;
            ValorItem = valorItem;
            Produto = produto;
        }

        public double CalcularSubTotal()
        {
            return ValorItem * Quantidade;
        }

        public override string ToString()
        {
            return Produto.Descricao
                + ", $"
                + ValorItem.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + CalcularSubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
