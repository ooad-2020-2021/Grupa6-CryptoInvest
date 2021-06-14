using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvest.Models
{
    public class Novost
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string Text { get; set; }
        [NotMapped]
        public DateTime Datum { get; set; }
    }
}
