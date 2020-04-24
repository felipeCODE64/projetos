using Exercicio5.Entidades;
using Exercicio5.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas figuras quer calcular a área? ");
            int n = int.Parse(Console.ReadLine());
            List<Poligono> poligonos = new List<Poligono>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"RETANGULO #{i}");
                Console.Write("Retangulo ou círculo (r/c): ");
                char resp = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Qual a cor do polígono (Perto/Azul/Vermelho)");
                CorPoligono corPoligono = Enum.Parse<CorPoligono>(Console.ReadLine());

                if (resp == 'r')
                {
                    Console.Write("Qual a altura do retângulo: ");
                    Double altura = Double.Parse(Console.ReadLine());
                    Console.Write("Qual a largura do retângulo: ");
                    Double largura = Double.Parse(Console.ReadLine());

                    poligonos.Add(new Retangulo (altura, largura, corPoligono));
                }
                else
                {
                    Console.Write("Qual o raio do círculo: ");
                    Double raio = Double.Parse(Console.ReadLine());
                    poligonos.Add(new Circulo (raio, corPoligono));
                }
            }
            foreach(Poligono poligono in poligonos)
            {
                Console.WriteLine(poligono.CalcularArea().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
