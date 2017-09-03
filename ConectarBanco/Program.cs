using System;

namespace ConectarBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria a coneccao
            Connection con = new Connection("localhost", "banco", "root", true);

            // imprime o conteudo da tabela escolhida
            con.ImprimeConteudo();

            // insere dados no banco
            con.InserirDado("dado1", "dado2", "dado3", "dado4");

            Console.ReadLine();
        }
    }
}
