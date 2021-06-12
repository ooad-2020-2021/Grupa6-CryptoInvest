using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Korisnik
    {
       
        public int ID { get; set; }
        public Novcanik novcanik { get; set; }

        public Portfolio portfolio { get; set; }

        
        public string username { get; set; }

    }
}
