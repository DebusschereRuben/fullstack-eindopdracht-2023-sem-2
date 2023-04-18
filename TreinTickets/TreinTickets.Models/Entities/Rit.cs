using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class Rit
    {
        public int RitId { get; set; }
        public int KlantId { get; set; }
        public int TreinId { get; set; }
        public int KlasseId { get; set; }
        public int PlaatsNummer { get; set; }
        public Stad VertrekStad { get; set; }
        public Stad BestemmingsStad { get; set; }
    }
}
