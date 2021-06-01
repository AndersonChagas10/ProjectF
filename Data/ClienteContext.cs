using Domain;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Data
{
    public class ClienteContext : DbContext
    {

        public ClienteContext : base("dbClientes"){
            
            
            }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
