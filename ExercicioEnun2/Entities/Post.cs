using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnun2.Entities
{
    internal class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Curtidas { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();   

        public Post()
        {
 
        }

        public Post(DateTime momento, string titulo, string conteudo, int curtida)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Curtidas = curtida;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoveComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {

            //Forma eficiente de mostragem e menos pesada
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Titulo);
            sb.Append(Curtidas);
            sb.Append(" Curtidas - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentarios: ");

            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }

            return sb.ToString();
        }
    }
}
