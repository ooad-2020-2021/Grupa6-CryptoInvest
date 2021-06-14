using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CryptoInvestt.Models;

namespace CryptoInvest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public DbSet<CryptoInvestt.Models.Portfolio> Portfolio { get; set; }
        public DbSet<CryptoInvestt.Models.Novcanik> Novcanik { get; set; }
        public DbSet<CryptoInvestt.Models.Korisnik> Korisnik { get; set; }
        public DbSet<CryptoInvestt.Models.Valuta> Valuta { get; set; }
        public DbSet<CryptoInvestt.Models.Transakcija> Transakcija { get; set; }
        public DbSet<CryptoInvestt.Models.Kurs> Kurs { get; set; }
        public DbSet<CryptoInvestt.Models.Iznos> Iznos { get; set; }
        public DbSet<CryptoInvestt.Models.Novost> Novost { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Iznos>().ToTable("Iznos");
            modelBuilder.Entity<Kurs>().ToTable("Kurs");
            modelBuilder.Entity<Novcanik>().ToTable("Novcanik");
            modelBuilder.Entity<Novost>().ToTable("Novost");
            modelBuilder.Entity<Portfolio>().ToTable("Portfolio");
            modelBuilder.Entity<Transakcija>().ToTable("Transakcija");
            modelBuilder.Entity<Valuta>().ToTable("Valuta");

            
        }
    }
}
