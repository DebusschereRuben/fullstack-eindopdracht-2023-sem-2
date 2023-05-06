using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using TreinTickets.Models;
using TreinTickets.Models.Data;
using TreinTickets.Models.Entities;
using TreinTickets.Services.Interfaces;

namespace TreinTickets.Controllers
{
    public class BestelController : Controller
    {
        private readonly TreinTicketsDbContext _context;
        private IService<Stad> _stadService;
        private IService<Rit> _ritService;
        private IService<TreinKlasse> _klasseService;

        public BestelController(TreinTicketsDbContext context, IService<Stad> stadService, 
            IService<Rit> ritService, IService<TreinKlasse> klasseService)
        {
            _context = context;
            _stadService = stadService;
            _ritService = ritService;
            _klasseService = klasseService;
        }

        public async Task<IActionResult> Search()//invullen form
        {
            var steden = await _stadService.GetAll();
            var stadList = new SelectList(steden, "Id", "Naam");
            ViewBag.StadList = stadList;

            var klasses = await _klasseService.GetAll();
            var klasseList = new SelectList(klasses, "Id", "Type");
            ViewBag.Klasses = klasseList;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
