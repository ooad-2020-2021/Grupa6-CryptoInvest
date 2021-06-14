using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class LimitTransakcija : Transakcija
    {
        [Required]
        public double Limit { get; set; }
        [Required]
        public int tipLimitTransakcije;
    }
}
