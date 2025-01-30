using System.Data;
using System.Linq.Expressions;
using Projeto01.Entities;
using Projeto01.Repositories;

namespace Projeto01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IMPRIMIR MENSAGEM(CONSOLE DO DOS)
            Console.WriteLine("\n *** CADASTRO DE CLIENTES *** \n");

            var cliente = new Cliente();
            cliente.Id = Guid.NewGuid();


            try
            {
                Console.WriteLine("Informe o NOME do cliente: ");
                cliente.Nome = Console.ReadLine();

                Console.WriteLine("Informe o CPF do cliente: ");
                cliente.Cpf = Console.ReadLine();

                Console.WriteLine("Informe o EMAIL do cliente: ");
                cliente.Email = Console.ReadLine();

                Console.WriteLine("Informe a DATA DE NASCIMENTO do cliente: ");
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());


                var clienteRepository = new ClienteRepository();
                clienteRepository.GravarArquivo(cliente);


                Console.WriteLine("\nCLIENTE CADASTRADO COM SUCESSO!");
                Console.WriteLine("\nDADOS DO CLIENTE: ");
                Console.WriteLine($"ID do cliente: {cliente.Id}");
                Console.WriteLine($"nome:  {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.Cpf}");
                Console.WriteLine($"Email: {cliente.Email}");


            }
            catch (Exception e)
            {
                Console.WriteLine("\n FALHA AO CADASTRAR O CLIENTE!");
                Console.WriteLine($"ERRO:{e.Message}");
            
            } 


            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");

            //PAUSAR O PROMPT DE COMANDOS
            Console.ReadKey();
        }
    }

}