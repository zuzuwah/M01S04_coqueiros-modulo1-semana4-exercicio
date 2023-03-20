using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
   public class Menu
{
    public void Exibir()
    {
        int opcao = 0;

        do
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Inserir Bebida");
            Console.WriteLine("2 - Alterar Bebida");
            Console.WriteLine("3 - Excluir Bebida");
            Console.WriteLine("4 - Listar todas as Bebidas");
            Console.WriteLine("5 - Listar todos os Sucos");
            Console.WriteLine("6 - Listar todos os Refrigerantes");
            Console.WriteLine("7 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    InserirBebida();
                    break;
                case 2:
                    AlterarBebida();
                    break;
                case 3:
                    Remover();
                    break;
                case 4:
                    ListarTodasBebidas();
                    break;
                case 5:
                    ListarTodosSucos();
                    break;
                case 6:
                    ListarTodosRefrigerantes();
                    break;
                case 7:
                    Console.WriteLine("Saindo do Menu...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 7);
    }

        public void ListarTodosRefrigerantes()
        {
            Repositorio.ImprimirRefrigerante();
        }

        public void ListarTodosSucos()
        {
            Repositorio.ImprimirSuco();
        }

        public void ListarTodasBebidas()
        {
            Repositorio.Listar();
        }

        public void Remover()
        {
            throw new NotImplementedException();
        }

        public void AlterarBebida()
        {
            //throw new NotImplementedException();
            Console.Write("\nDigite o nome da bebida a ser alterada: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o novo tipo da bebida: ");
            string novoTipo = Console.ReadLine();

        try
        {
            Repositorio.Alterar();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro ao alterar bebida: {e.Message}");
        }
        }

        public void InserirBebida()
    {
        Console.WriteLine("Digite o tipo da bebida:");
        string tipo = Console.ReadLine();

        Console.WriteLine("Digite a quantidade em mililitros:");
        decimal ml = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome da bebida:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o valor de compra da bebida:");
        decimal valor = decimal.Parse(Console.ReadLine());

        Bebida bebida = new Bebida()
        {
            Tipo = tipo,
            MiliLitro = ml,
            NomeBebida = nome,
            ValorCompra = valor
        };

        Repositorio.InserirBebida(bebida);

        Console.WriteLine("Bebida adicionada com sucesso!");
    }

        
    }
}
