using System;

namespace ConectarBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria a coneccao
            Connection con = new Connection("localhost", "sofia", "root", true);

            // imprime o conteudo da tabela escolhida
            con.ImprimeConteudo();

            // insere dados no banco
            //con.InserirDado("Exemplo");

            Console.ReadLine();
        }
    }
}
