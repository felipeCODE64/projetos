using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.Entidades
{
    class Publicacao
    {
        public DateTime DataHora { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Curtidas { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public Publicacao()
        {
        }

        public Publicacao(DateTime dataHora, string titulo, string conteudo, int curtidas)
        {
            DataHora = dataHora;
            Titulo = titulo;
            Conteudo = conteudo;
            Curtidas = curtidas;
        }
        public void AdicionarComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }
        public void RemoverComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Titulo);
            sb.Append(Curtidas);
            sb.Append("Curtidas - ");
            sb.AppendLine(DataHora.ToString("dd/mm/aaa HH:mm:ss"));
            sb.AppendLine(Conteudo);
            
            foreach(Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            
            return sb.ToString();


    }

    }


}
