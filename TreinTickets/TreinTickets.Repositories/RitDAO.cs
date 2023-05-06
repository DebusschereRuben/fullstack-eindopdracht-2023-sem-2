using Microsoft.EntityFrameworkCore;
using TreinTickets.Models.Data;
using TreinTickets.Models.Entities;
using TreinTickets.Repositories.Interfaces;

namespace TreinTickets.Repositories
{
    public class RitDAO : IDAO<Rit>
    {
        private readonly TreinTicketsDbContext _dbContext;

        public RitDAO()
        {
            _dbContext = new TreinTicketsDbContext();
        }
        public async Task Add(Rit entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public Task Delete(Rit entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Rit>> GetAll()
        {
            try
            {
                return await _dbContext.Ritten
                    .Include(b => b.Treinen)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error in DAO");
                throw new Exception("error DAO Rit");

            }
        }

        public async Task<Rit> GetAsync(int id)
        {
            try
            {

                return await _dbContext.Ritten.Where(b => b.Id == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            { throw new Exception("error DAO Rit"); }
        }

        public Task Update(Rit entity)
        {
            throw new NotImplementedException();
        }
    }
}