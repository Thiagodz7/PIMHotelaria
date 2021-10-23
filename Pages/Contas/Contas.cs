using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIMHotelaria.Pages.Contas
{
    public class Contas
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Agencia")]
        public int agencia { get; set; }

        [Required]
        [Display(Name = "Titular")]
        public string titular { get; set; }

        [Required]
        [Display(Name = "Número da Conta")]
        public int num_Conta { get; set; }

        [Required]
        [Display(Name = "Tipo do Cartão")]
        public string tp_Cartão { get; set; }

        [Required]
        [Display(Name = "Número do Cartão")]
        public int num_Cartão { get; set; }

        [Required]
        [Display(Name = "CVC")]
        public int cvc { get; set; }

        //[Required]
        //[Display(Name = "Código Cliente")]
        //[ForeignKey("clienteID")]
        //public int ClienteFK{ get; set; }

        //public Clientes.Cliente clienteID { get; set; }
    }
}
