using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Transakcija
    {
        public int ID { get; set; }
        public DateTime datum { get; set; }

        public double KolicinaValute { get; set; }

        public double Cijena { get; set; }

        public Valuta Valuta { get; set; }
    }
}
