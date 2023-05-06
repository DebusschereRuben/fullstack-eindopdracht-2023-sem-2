using TreinTickets.Models.Entities;
using TreinTickets.Repositories.Interfaces;
using TreinTickets.Services.Interfaces;

namespace TreinTickets.Services
{
    public class RitService : IService<Rit>
    {
        private IDAO<Rit> _ritDAO;

        public RitService(IDAO<Rit> ritDAO)
        {
            _ritDAO = ritDAO;
        }
        public Task Add(Rit entity)
        {
            return _ritDAO.Add(entity);
        }

        public Task Delete(Rit entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Rit>> GetAll()
        {
            return _ritDAO.GetAll();
        }

        public Task<Rit> GetAsync(int id)
        {
            return _ritDAO.GetAsync(id);
        }

        public Task Update(Rit entity)
        {
            throw new NotImplementedException();
        }
    }
}