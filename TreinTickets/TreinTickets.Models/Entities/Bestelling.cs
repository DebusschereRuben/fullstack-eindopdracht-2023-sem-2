using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class Bestelling
    {
        public int Id { get; set; }
        public double Totaalbedrag { get; set; }

        public string KlantId { get; set; }

        public Tickets Ticket { get; set; }
        public int TicketsId { get; set; }

        public string Status { get; set; }

        public virtual AspNetUser Klant { get; set; }
    }
}
