using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Novost
    {
        public int ID { get; set; }
        public string Naslov { get; set; }
        public string Text { get; set; }
        public DateTime Datum { get; set; }
    }
}
