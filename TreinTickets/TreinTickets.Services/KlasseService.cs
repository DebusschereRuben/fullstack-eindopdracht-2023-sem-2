using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinTickets.Models.Entities;
using TreinTickets.Repositories.Interfaces;
using TreinTickets.Services.Interfaces;

namespace TreinTickets.Services
{
    public class KlasseService : IService<TreinKlasse>
    {
        private IDAO<TreinKlasse> _klasseDAO;

        public KlasseService(IDAO<TreinKlasse> klasseDAO)
        {
            _klasseDAO = klasseDAO;
        }

        public Task Add(TreinKlasse entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(TreinKlasse entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TreinKlasse>> GetAll()
        {
            return _klasseDAO.GetAll();
        }

        public Task<TreinKlasse> GetAsync(int id)
        {
            return _klasseDAO.GetAsync(id);
        }

        public Task Update(TreinKlasse entity)
        {
            throw new NotImplementedException();
        }
    }
}
