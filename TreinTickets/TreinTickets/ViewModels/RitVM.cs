using TreinTickets.Models.Entities;

namespace TreinTickets.ViewModels
{
    public class RitVM
    {
        public TreinKlasse TreinKlasse { get; set; }
        public int PlaatsNummer { get; set; }
        public TreinKlasse VertrekStad { get; set; }
        public TreinKlasse BestemmingsStad { get; set; }
        public DateTime VertrekDag { get; set; }
    }
}
