using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvestt.Models
{
    public class Valuta
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public double TrenutnaVrijednost { get; set; } = 30000;

        //[NotMapped]
        //public List<double> DnevneVrijednosti { get; set; }

        //[NotMapped]
        //public List<double> SedmicneVrijednosti { get; set; }

        //[NotMapped]
        //public List<double> MjesecneVrijednosti { get; set; }

        //[NotMapped]
        //public List<double> GodisnjeVrijednosti { get; set; }
        public List<Double> dajDnevneVrijednosti(string Naziv) {return new List<Double>();}
        public double dajMax24h(string Naziv) { return 0.6; } 
        public double dajMin24h(string Naziv) { return 1; }
    }
}
