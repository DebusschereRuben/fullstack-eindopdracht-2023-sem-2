using TreinTickets.Models.Entities;

namespace TreinTickets.ViewModels
{
    public class RitVM
    {
        public TreinKlasse TreinKlasse { get; set; }
        public int PlaatsNummer { get; set; }
        public Stad VertrekStad { get; set; }
        public Stad BestemmingsStad { get; set; }
        public DateTime VertrekDag { get; set; }
    }
}
