using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace houseasy_API.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Endereco { get; set; }

        [StringLength(12)]
        [MinLength(9)]
        public string Telefone { get; set; }
        public string Ocupacao { get; set; }
    }
}