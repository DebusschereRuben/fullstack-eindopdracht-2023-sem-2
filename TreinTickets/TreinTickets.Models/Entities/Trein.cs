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
        public int VertrekStadId { get; set; }
        public DateTime Vertrektijd { get; set; }
        public int BestemmingsStadId { get; set; }
        public DateTime Duur { get; set; }
        public int AantalZitPlaatsen { get; set; }

        public virtual Rit Rit { get; set; }
    }
}
