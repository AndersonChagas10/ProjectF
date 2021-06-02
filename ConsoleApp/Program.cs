using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INICIANDO....");

            var ctx = new DBContext();

            Cliente cli = new Cliente();
            cli.id = 1;
            cli.nome = "Anderson";
            cli.email = "aachagas@yahoo.com.br";
            ctx.Clientes.Add(cli);

            Produto prod = new Produto();
            prod.descricao = "Mouse USB";
            prod.preco = 10.50;
            prod.marca = "Microsoft";
            ctx.Produto.Add(prod);

            ctx.SaveChanges();

            Console.WriteLine("FIM....");
            Console.ReadKey();
        }
    }
}
