using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public int BestellingId { get; set; }
        public string Naam { get; set; }
        public string Adress { get; set; }
        public double PrijsPerNacht { get; set; }

    }
}
