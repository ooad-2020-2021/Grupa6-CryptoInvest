using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class PremiumKorisnik
    {
        public int ID { get; set; }
        public DateTime DatumIsteka { get; set; }
        public List<Kurs> Kursevi { get; set; }
    }
}
