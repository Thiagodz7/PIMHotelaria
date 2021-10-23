using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIMHotelaria.Pages.Clientes
{
    public class Clientes
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nome do Cliente")]
        public string nome_Cliente { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public int cpf { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public int telefone { get; set; }

        [Required]
        [Display(Name = "Apelido")]
        public string apelido { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string senha { get; set; }
    }
}
