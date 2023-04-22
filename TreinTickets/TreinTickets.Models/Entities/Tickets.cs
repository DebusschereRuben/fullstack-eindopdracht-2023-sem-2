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
        public int Id { get; set; }
        public Rit Rit { get; set; }
        public int RitId { get; set; }

    }
}
