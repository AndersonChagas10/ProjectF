using Domain;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Data
{
    public class Context : DbContext
    {

        public Context() : base("dbProject")
        {

        } 
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
