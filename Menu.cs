using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
    public static class Menu
    {
        public static void DisplayInicial()
        {
            Console.Clear(); //Método que vai limpar os dados em tela
            Console.WriteLine("\n"); //Quebra de linha com o \n e WriteLine
            Console.WriteLine("Distribuidora de Bebidas:"); //Titulo do console
            Console.WriteLine("*******************************************************"); //Corte da linha
            Console.WriteLine("\n"); //Quebra de linha com o \n e WriteLine
        }

         public static string consoleMenuPrincipal()
        {
            Console.WriteLine("1 - Adicionar Bebida ");
            Console.WriteLine("2 - Alterar Bebida ");
            Console.WriteLine("3 - Excluir Bebida ");
            Console.WriteLine("4 - Listar Bebidas ");
            Console.WriteLine("5 - Sair ");
            return Console.ReadLine();
        }

            public static void opcaoMenuPrincipal()
        {
            string Opcao;
            do
            {
                Opcao = consoleMenuPrincipal();
                switch(Opcao)
                {
                    case "1":
                        Repositório.AdicionarBebida(CadastrarBebida()); break;
                    case "2":
                        Repositório.AlterarBebida(SelecionarBebida()); break;
                    case "3":
                        Repositório.ExcluirBebida(SelecionarBebida().Id); break;
                    case "4":
                        ListarBebidas(); break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Opção Inválida"); break;
                }
            }
            while (Opcao != "5");
        }

        private static void ListarBebidas()
        {
            foreach (Bebida bebida in Repositório.listaBebidas)
            {
                if (bebida is Suco suco)
                {
                    Console.WriteLine("Index: {0} - ID: {1} - Tipo: {2} - Tipo Caixa: {3}", Repositório.listaBebidas.IndexOf(bebida), bebida.Id, bebida.Tipo, suco.TipoCaixa);
                }
                else if (bebida is Refrigerante refrigerante)
                {
                    Console.WriteLine("Index: {0} - ID: {1} - Tipo: {2} - Vidro: {3}", Repositório.listaBebidas.IndexOf(bebida), bebida.Id, bebida.Tipo, refrigerante.vidro);
                }
                else
                {
                    Console.WriteLine("Index: {0} - ID: {1} - Tipo: {2}", Repositório.listaBebidas.IndexOf(bebida), bebida.Id, bebida.Tipo);
                }
            }
        }

        private static Bebida SelecionarBebida()
        {
            ListarBebidas();
            int indexLista = int.Parse(Console.ReadLine());
            Bebida bebida = Repositório.listaBebidas[indexLista];
            return bebida;
        }

        public static Bebida CadastrarBebida()
        {
            Bebida bebida = new Bebida();
            bebida.Id = int.Parse(Console.ReadLine());
            bebida.Tipo = Console.ReadLine();
            return bebida;
        }
    }
}
