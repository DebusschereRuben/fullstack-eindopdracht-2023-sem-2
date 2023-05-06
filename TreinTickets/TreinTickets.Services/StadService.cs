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
    public class StadService : IService<Stad>
    {
        private IDAO<Stad> _stadDAO;

        public StadService(IDAO<Stad> stadDAO)
        {
            _stadDAO = stadDAO;
        }
        public Task Add(Stad entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Stad entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Stad>> GetAll()
        {
            return _stadDAO.GetAll();
        }

        public Task<Stad> GetAsync(int id)
        {
            return _stadDAO.GetAsync(id);
        }

        public Task Update(Stad entity)
        {
            throw new NotImplementedException();
        }
    }
}
