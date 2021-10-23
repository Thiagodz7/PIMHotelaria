using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIMHotelaria.Pages.Reservas
{
    public class Reservas
    {
        //Tabela de Reservas - Deverá ser Adicionado a FK...
        public int ID { get; set; }

        [Required]
        [Display(Name = "Data Entrada")]
        [DataType(DataType.Date)]
        public DateTime dt_Entrada { get; set; }


        [Required]
        [Display(Name = "Data Saída")]
        [DataType(DataType.Date)]
        public DateTime dt_Saida { get; set; }

        [Required]
        [Display(Name = "Número de Pessoas")]
        public int num_Pessoas { get; set; }

        [Required]
        [Display(Name = "Método de Acesso")]
        public bool mtd_Acesso { get; set; }

        //[Required]
        //[Display(Name = "Código Cliente")]
        //[ForeignKey("clienteFK")]
        //public string Cliente_FK { get; set; }

        //public Clientes.Cliente clienteID { get; set; }


        ///<<ATENÇÃO!!!!!>>
        /// <SUMARY>ADICIONAR ESSA CHAVE ESTRANGEIRA APÓS CRIAR TABELA QUARTOS<SUMARY>
        ///
        //[Required]
        //[Display(Name = "Código Cliente")]
        //[ForeignKey("cliente_FK")]
        //public string Quarto_FK { get; set; }

        //public Quartos.Quarto Quarto_FK { get; set; }
    }
}
