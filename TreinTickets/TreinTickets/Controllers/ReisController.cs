using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using TreinTickets.Models;
using TreinTickets.Models.Data;
using TreinTickets.Models.Entities;
using TreinTickets.Services.Interfaces;
using TreinTickets.ViewModels;

namespace TreinTickets.Controllers
{
    public class ReisController : Controller
    {
        private readonly TreinTicketsDbContext _context;
        private IService<Stad> _stadService;
        private IService<Rit> _ritService;
        private IService<TreinKlasse> _klasseService;

        private readonly IMapper _mapper;


        public ReisController(TreinTicketsDbContext context, IService<Stad> stadService, 
            IService<Rit> ritService, IService<TreinKlasse> klasseService, 
            IMapper mapper)
        {
            _context = context;
            _stadService = stadService;
            _ritService = ritService;
            _klasseService = klasseService;
            _mapper = mapper;
            
        }

        public async Task<IActionResult> Search()//invullen form
        {
            var reisCreate = new ReisCreateVM()
            {
                Vertreksteden = new SelectList(await _stadService.GetAll()
                , "Id", "Naam"),
                Bestemmingssteden = new SelectList(await _stadService.GetAll()
                , "Id", "Naam"),
                TreinKlasses = new SelectList(await _klasseService.GetAll()
                , "Id", "Type"),

                VertrekDag = DateTime.Now
            };

            return View(reisCreate);
        }

        public async Task<IActionResult> Ritten()
        {
            var ritten = await _ritService.GetAll();
            List<RitVM> listVM = _mapper.Map<List<RitVM>>(ritten);
            return View(listVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(ReisCreateVM reisModel)
        {
            if (ModelState.IsValid) 
            {
                var reis = _mapper.Map<Rit>(reisModel);
                await _ritService.Add(reis);
                return View("Ritten");
            }

            reisModel.Vertreksteden = new SelectList(await _stadService.GetAll()
                , "Id", "Naam", reisModel.VertrekStadId);

            reisModel.Bestemmingssteden = new SelectList(await _stadService.GetAll()
                , "Id", "Naam", reisModel.BestemmingsStadId);

            reisModel.TreinKlasses = new SelectList(await _klasseService.GetAll()
                , "Id", "Type", reisModel.TreinKlasseId);

            reisModel.VertrekDag = DateTime.Now;

            return View(reisModel);
        }
    }
}
