using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cliente
    {
        public int id { get; set; }

        [MinLength(4)]
        [MaxLength(50)]
        [Column("name")]
        public string nome { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string email { get; set; }

        [NotMapped]
        public string idade { get; set; }

       
    }
}
