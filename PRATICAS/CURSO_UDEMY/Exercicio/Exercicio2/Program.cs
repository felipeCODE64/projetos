using Exercicio2.Entidades;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma boa viagem!!");
            Comentario c2 = new Comentario("Uau! que lindo lugar.");

            Publicacao p1 = new Publicacao
                (
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando pelo mundo",
                "Estou visitando o mundo todo.",
                6
                );
            p1.AdicionarComentario(c1);
            p1.AdicionarComentario(c2);

            Comentario c3 = new Comentario("Boa noite");
            Comentario c4 = new Comentario("Caralho de inglês");

            Publicacao p2 = new Publicacao
                (
                DateTime.Parse("28/07/2018 23:14:19"),
                "POrra de inglês",
                "Vão tudo tomar no cu.",
                48
                );
            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
