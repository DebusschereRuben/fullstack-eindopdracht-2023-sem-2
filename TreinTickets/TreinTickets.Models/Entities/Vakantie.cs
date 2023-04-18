using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinTickets.Models.Entities
{
    public class Vakantie
    {
        public DateOnly BeginDag { get; set; }
        public DateOnly EindDag { get; set; }
    }
}
