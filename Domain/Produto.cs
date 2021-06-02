using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    [Table("produtos")]
    public class Produto
    {
        public int id { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public string marca { get; set; }
        public double preco { get; set; }
    }
}