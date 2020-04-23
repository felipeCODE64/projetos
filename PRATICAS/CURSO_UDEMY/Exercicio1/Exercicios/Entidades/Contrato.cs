using System;

namespace Exercicios.Entidades
{
    class Contrato
    {
        public DateTime Data { get; set; }
        public Double ValorHora { get; set; }
        public int Hora { get; set; }

        public Contrato()
        {
        }
        public Contrato(DateTime data, double valorHora, int hora)
        {
            Data = data;
            ValorHora = valorHora;
            Hora = hora;
        }

        public Double ValorTotal()
        {
            return Hora * ValorHora;
        }
    }
}
