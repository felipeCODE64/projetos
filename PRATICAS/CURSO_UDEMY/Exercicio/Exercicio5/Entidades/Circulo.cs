using Exercicio5.Entidades.Enums;
using System;


namespace Exercicio5.Entidades
{
    class Circulo : Poligono
    {
        public Double Raio { get; set; }

        public Circulo(Double raio, CorPoligono corPoligono) : base(corPoligono)
        {
            Raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
