using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Iznos
    {
        [Key]
        [Required]
        public int valutaId;
        [Required]
        public double iznos { get; set; }
    }
}
