using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Domains
{
    [Table("Numeros")]
    public class Operacao
    {
        [Column(TypeName = "DOUBLE")]
        [Required(ErrorMessage = "Tem que ser digitado um numero")]
        public double N1 { get; set; }

        [Column(TypeName = "DOUBLE")]
        [Required(ErrorMessage = "Tem que ser digitado um numero")]
        public double N2 { get; set; }


    }
}
