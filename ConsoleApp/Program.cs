using Data;
using Domain;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");
            var ctx = new ClienteContext();


            Cliente cli = new Cliente();
            cli.id = 1;
            cli.nome = "Anderson";
            cli.email = "aachagas@yahoo.com.br";
            ctx.Clientes.Add(cli);
            Console.WriteLine("Fim...");
            Console.ReadKey();

        }
    }
}
