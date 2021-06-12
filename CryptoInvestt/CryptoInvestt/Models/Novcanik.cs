using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Novcanik
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [NotMapped]
        public List<Iznos> Valute { get; set; }

        [Required]
        public int korisnikID;
        [Required]
        public string iznosi { get; set; }

        public double UkupniIznos { get; set; }


    }
}
