using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvest.Models
{
    public class Iznos
    {
        [Key]
        [Required]
        public int valutaId { get; set; }
        [Required]
        public string kolicina { get; set; }
    }
}
