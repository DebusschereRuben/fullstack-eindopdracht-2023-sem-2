using TreinTickets.Models.Entities;

namespace TreinTickets.ViewModels
{
    public class BestellingVM
    {
        public double TotaalBedrag { get; set; }
        public Tickets Ticket { get; set; }
        public string Status { get; set; }

    }
}
