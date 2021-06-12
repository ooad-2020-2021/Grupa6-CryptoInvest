using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Novcanik
    {
        public int ID { get; set; }

        [NotMapped]

        public Dictionary<Valuta, int> Valute { get; set; }
        public double UkupniIznos { get; set; }

    }
}
