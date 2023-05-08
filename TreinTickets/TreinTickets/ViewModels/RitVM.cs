using System.ComponentModel.DataAnnotations;
using TreinTickets.Models.Entities;

namespace TreinTickets.ViewModels
{
    public class RitVM
    {
        public string? TreinKlasse { get; set; }

        public int PlaatsNummer { get; set; }

        public string? VertrekStad { get; set; }

        public string? BestemmingsStad { get; set; }

        public DateTime VertrekDag { get; set; }
    }
}
