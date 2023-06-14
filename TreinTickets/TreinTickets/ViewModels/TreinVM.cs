using TreinTickets.Models.Entities;

namespace TreinTickets.ViewModels
{
    public class TreinVM
    {
        public int Id { get; set; }
        public int VertrekStadId { get; set; }
        public int BestemmingsStadId { get; set; }
        public int AantalZitplaatsen { get; set; }
    }
}
