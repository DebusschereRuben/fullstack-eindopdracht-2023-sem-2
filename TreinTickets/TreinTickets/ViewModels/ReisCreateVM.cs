using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TreinTickets.Models.Entities;

namespace TreinTickets.ViewModels
{
    public class ReisCreateVM
    {
        
        [Required]
        [Display(Name = "Class")]
        public int TreinKlasseId { get; set; }
        public IEnumerable<SelectListItem>? TreinKlasses { get; set; }

        
        [Required]
        [Display(Name = "From")]
        public int VertrekStadId { get; set; }
        public IEnumerable<SelectListItem>? Vertreksteden { get; set; }

        
        [Required]
        [Display(Name = "To")]
        public int BestemmingsStadId { get; set; }
        public IEnumerable<SelectListItem>? Bestemmingssteden { get; set; }

        
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}")]
        [DateCheck]
        [Display(Name = "Departure")]
        public DateTime VertrekDag { get; set; }


        public class DateCheck : ValidationAttribute
        {
            protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
            {
                DateTime vertrekdag = (DateTime)value;
                TimeSpan difference = vertrekdag.Date - DateTime.Today;
                if (difference < TimeSpan.Zero || difference > TimeSpan.FromDays(14))
                {
                    return new ValidationResult("U kunt maar 14 dagen op voorhand boeken");
                }
                return ValidationResult.Success;
            }
        }
    }
}
