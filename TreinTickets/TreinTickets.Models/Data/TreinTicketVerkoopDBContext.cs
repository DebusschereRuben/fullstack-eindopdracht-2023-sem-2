using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinTickets.Models.Entities;

namespace TreinTickets.Models.Data
{
    public class TreinTicketVerkoopDBContext : DbContext
    {
        public TreinTicketVerkoopDBContext() { }

        public TreinTicketVerkoopDBContext(DbContextOptions<TreinTicketVerkoopDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQL19_VIVES;Database=TreinTicketsDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public virtual DbSet<Bestelling> Bestellingen { get; set; } = null!;
        public virtual DbSet<Hotel> Hotels { get; set; } = null!;
        public virtual DbSet<Rit> Ritten { get; set; } = null!;
        public virtual DbSet<Stad> Steden { get; set; } = null!;
        public virtual DbSet<Tickets> Tickets { get; set; } = null!;
        public virtual DbSet<Trein> Treinen { get; set; } = null!;
        public virtual DbSet<TreinKlasse> TreinKlasses { get; set; } = null!;
        public virtual DbSet<Vakantie> Vakanties { get; set; } = null!;

        
    }
}
