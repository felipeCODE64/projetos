using Exercicio5.Entidades.Enums;
using System;


namespace Exercicio5.Entidades
{
    abstract class Poligono
    {
        public CorPoligono corPoligono { get; set; }

        public Poligono(CorPoligono corpoligono)
        {
            corPoligono = corpoligono;
        }

        public abstract Double CalcularArea();
    }

}
