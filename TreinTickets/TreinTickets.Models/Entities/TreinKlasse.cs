using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class TreinKlasse
    {
        [Key]
        public int KlasseId { get; set; }
        public string Type { get; set; }
    }
}
