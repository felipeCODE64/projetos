using System;
using System.Collections.Generic;
using System.Text;
using Exercicio3.Entidades.Enums;
using System.Globalization;

namespace Exercicio3.Entidades
{
    class Orcamento
    {
        public DateTime DataHora { get; set; }
        public StatusOrcamento  Status { get; set; } //propriedade de tipo status, ela já vai pegam do ENUM
        public Cliente Cliente { get; set; } //prorriedade do tipo cliente, ela já vai pegar info da classe cliente.
        public List<ItensOrcamento> Itens { get; set; } = new List<ItensOrcamento>();//propriedades do tipo lista itensormamento, pois vai ter varios itens para esse orcamento. Já foi instaciado pra ter valor 0;

        public Orcamento() //Contrutor pardrão sem nenhum argumetno
        {
        }

        public Orcamento(DateTime dataHora, StatusOrcamento status, Cliente cliente) //Construtor com os argumentos originais que vão ficar gravando em orcamento
        {
            DataHora = dataHora;
            Status = status;
            Cliente = cliente;
        }

        public void InserirItem(ItensOrcamento item) //Função de inserir um novo item no orcamento
        {
            Itens.Add(item);
        }

        public void RemoverItem(ItensOrcamento item) //Função remover item de uma lista
        {
            Itens.Remove(item);
        }

        public double CalculaTotalOrcamento() //Função para calcular total do orcamento
        {
            double soma = 0.0;
            foreach (ItensOrcamento item in Itens) //vai percorrer no itens da lista ItensOrcamento
            {
                soma = soma + item.CalcularSubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data e Hora do Orcamento: " + DataHora.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Orcamento: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do Orcamento:");
            foreach (ItensOrcamento item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total Orcamento: $" + CalculaTotalOrcamento().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
