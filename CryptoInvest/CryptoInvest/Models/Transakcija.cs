using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvest.Models
{
    public class Transakcija
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [NotMapped]
        public DateTime datum { get; set; }
        [Required]
        public double KolicinaValute { get; set; }
        [Required]
        public double Cijena { get; set; }
        [NotMapped]
        public Valuta Valuta { get; set; }
        [Required]
        public int portfolioID;
        [Required]
        public int valutaID;

        [Required]
        public int tipTransakcije { get; set; }
        public double limit;
    }
}
