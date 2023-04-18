using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class Vakantie
    {
        [Key]
        public int Id { get; set; }
        public DateTime BeginDag { get; set; }
        public DateTime EindDag { get; set; }
    }
}
