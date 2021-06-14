using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Kurs
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string detaljno { get; set; }
    }
}
