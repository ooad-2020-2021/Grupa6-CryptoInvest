using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvest.Models
{
    public class Portfolio
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [NotMapped]
        public List<Transakcija> Transakcije { get; set; }
        [Required]
        public int korisnikID;
    }
}
