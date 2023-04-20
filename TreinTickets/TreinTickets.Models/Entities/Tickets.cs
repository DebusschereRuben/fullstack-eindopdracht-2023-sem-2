using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class Tickets
    {
        public int TicketId { get; set; }
        public int TreinId { get; set; }
        public int RitId { get; set; }

    }
}
