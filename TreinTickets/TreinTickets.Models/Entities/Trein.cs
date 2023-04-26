using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class Trein
    {
        public int Id { get; set; }

        public Stad VertrekStad { get; set; }
        public int VertrekStadId { get; set; }
        public DateTime Vertrektijd { get; set; }

        public Stad BestemmingsStad { get; set; }
        public int BestemmingsStadId { get; set; }
        public double Duur { get; set; }
        public int AantalZitPlaatsen { get; set; }

        public virtual Rit Rit { get; set; }
    }
}
