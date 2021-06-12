using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class PremiumKorisnik : Korisnik
    {
        //public int ID { get; set; }
        [NotMapped]
        public DateTime DatumIsteka { get; set; }
        
        [NotMapped]
        public List<Kurs> Kursevi { get; set; }
    }
}
