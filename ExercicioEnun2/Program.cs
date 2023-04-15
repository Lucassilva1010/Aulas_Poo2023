using ExercicioEnun2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnun2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Comentario comentario1 = new Comentario("Tenha uma boa viagem!");
            Comentario comentario2 = new Comentario("UAuu isso é Incrivel!");
            Comentario comentario5 = new Comentario("Esse cara é feraaaaaaaaaaaaaaa!");
            Post post1 = new Post(
                DateTime.Parse("11/04/2023"),
                "Viajando para Nova elandia ",
                "Indo visitar esse país maravilhoso!",
                100
                );

            post1.AddComentario(comentario1);
            post1.AddComentario(comentario2);
            post1.AddComentario(comentario5);


            Comentario comentario3 = new Comentario("Boa noite!");
            Comentario comentario4 = new Comentario("Que a força esteja com você!");

            Post post2 = new Post(
                DateTime.Parse("11/04/2023"),
                "Boa noite Galera!",
                "Vejo vocês amanhã!",
                20
                );

            post2.AddComentario(comentario3);
            post2.AddComentario(comentario4);


            Console.WriteLine(post1);
            Console.WriteLine(post2);

        }
    }
}
