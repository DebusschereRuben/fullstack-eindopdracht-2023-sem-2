using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public partial class Rit
    {
        public Rit()
        {
            Treinen = new HashSet<Trein>();
        }
        public int RitId { get; set; }
        public int KlantId { get; set; }
        public int TreinId { get; set; }
        public int KlasseId { get; set; }
        public int PlaatsNummer { get; set; }
        public int VertrekStadId { get; set; }
        public int BestemmingsStadId { get; set; }

        public virtual AspNetUser Klant { get; set; }
        public virtual ICollection<Trein> Treinen { get; set; }
    }
}
