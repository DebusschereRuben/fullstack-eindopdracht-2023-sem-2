using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinTickets.Models.Data;
using TreinTickets.Models.Entities;
using TreinTickets.Repositories.Interfaces;

namespace TreinTickets.Repositories
{
    public class StadDAO : IDAO<Stad>
    {

        private readonly TreinTicketsDbContext _dbContext;

        public StadDAO()
        {
            _dbContext = new TreinTicketsDbContext();
        }
        public Task Add(Stad entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Stad entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Stad>> GetAll()
        {
            try
            {
                return await _dbContext.Steden.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error in DAO");
                throw new Exception("error DAO Stad");

            }
        }

        public async Task<Stad> GetAsync(int id)
        {
            try
            {

                return await _dbContext.Steden.Where(b => b.Id == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            { throw new Exception("error DAO Stad"); }
        }

        public Task Update(Stad entity)
        {
            throw new NotImplementedException();
        }
    }
}
