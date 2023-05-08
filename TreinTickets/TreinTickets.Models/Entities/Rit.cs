using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int Id { get; set; }
        public string KlantId { get; set; }

        public TreinKlasse TreinKlasse { get; set; }
        public int TreinKlasseId { get; set; }

        public int PlaatsNummer { get; set; }

        public TreinKlasse VertrekStad { get; set; }
        public int VertrekStadId { get; set; }

        public TreinKlasse BestemmingsStad { get; set; }
        public int BestemmingsStadId { get; set; }

        public DateTime VertrekDag { get; set; }

        public virtual AspNetUser Klant { get; set; }
        public virtual ICollection<Trein> Treinen { get; set; }

        public virtual Tickets TicketsnrNavigation { get; set; }

    }
}

