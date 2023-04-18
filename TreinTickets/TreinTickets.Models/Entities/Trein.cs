using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class Trein
    {
        public int TreinId { get; set; }
        public Stad VertrekStad { get; set; }
        public DateTime Vertrektijd { get; set; }
        public Stad BestemmingsStad { get; set; }
        public DateTime Duur { get; set; }
        public int aantalZitPlaatsen { get; set; }
    }
}
