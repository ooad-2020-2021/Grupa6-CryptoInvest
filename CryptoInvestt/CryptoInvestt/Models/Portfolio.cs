using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Portfolio
    {
        public int ID { get; set; }
        [NotMapped]
        public List<Transakcija> Transakcije { get; set; }
    }
}
