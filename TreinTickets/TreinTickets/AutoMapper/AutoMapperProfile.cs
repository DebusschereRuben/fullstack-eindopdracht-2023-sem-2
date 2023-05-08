using AutoMapper;
using TreinTickets.Models.Entities;
using TreinTickets.ViewModels;

namespace TreinTickets.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RitVM, Rit>();
            CreateMap<Rit, RitVM>();


            CreateMap<ReisCreateVM, Rit>();
            CreateMap<Rit, ReisCreateVM>();
        }
    }
}
