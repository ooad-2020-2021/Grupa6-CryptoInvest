using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Valuta
    {
        public int ID { get; set; }

        public string Naziv { get; set; }
        public double TrenutnaVrijednost { get; set; }

        [NotMapped]
        public List<double> DnevneVrijednosti { get; set; }

        [NotMapped]
        public List<double> SedmicneVrijednosti { get; set; }

        [NotMapped]
        public List<double> MjesecneVrijednosti { get; set; }

        [NotMapped]
        public List<double> GodisnjeVrijednosti { get; set; }

        public double Max24h { get; set; }
        public double Min24h { get; set; }
    }
}
