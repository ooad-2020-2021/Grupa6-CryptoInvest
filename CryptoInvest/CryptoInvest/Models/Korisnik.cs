using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoInvest.Models
{
    public class Korisnik
    {
       
        [Key]
        [Required]
        public int ID { get; set; }
        [NotMapped]
        public Novcanik novcanik { get; set; }
        [NotMapped]
        public Portfolio portfolio { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }

        public Korisnik(int ID, string username, string password, string email)
        {
            this.ID = ID;
            this.username = username;
            this.password = password;
            this.email = email;
        }

    }
}
