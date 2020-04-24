using Exercicio5.Entidades.Enums;
using System;

namespace Exercicio5.Entidades
{
    class Retangulo : Poligono
    {
        public Double Largura { get; set; }
        public Double Altura { get; set; }

        public Retangulo(Double largura, Double altura, CorPoligono corPoligono) : base(corPoligono)
        {
            Largura = largura;
            Altura = altura;
        }
        public override double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}
