using Data;
using Domain;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");
            var ctx = new Context();


            Cliente cli = new Cliente();
            cli.id = 1;
            cli.nome = "Anderson";
            cli.email = "aachagas@yahoo.com.br";
            ctx.Clientes.Add(cli);

           


            Produto prod = new Produto();
            prod.CodProd = 1;
            prod.Descricao = "Notebook";
            prod.Preco = "1500";
            ctx.Produto.Add(prod);
           

            ctx.SaveChanges();
            Console.WriteLine("Fim...");
            Console.ReadKey();

        }
    }
}
