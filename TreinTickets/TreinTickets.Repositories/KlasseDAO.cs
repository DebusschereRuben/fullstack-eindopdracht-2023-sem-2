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
    public class KlasseDAO : IDAO<TreinKlasse>
    {
        private readonly TreinTicketsDbContext _dbContext;

        public KlasseDAO()
        {
            _dbContext = new TreinTicketsDbContext();
        }
        public Task Add(TreinKlasse entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(TreinKlasse entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TreinKlasse>> GetAll()
        {
            try
            {
                return await _dbContext.TreinKlasses.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error in DAO");
                throw new Exception("error DAO Stad");

            }
        }

        public async Task<TreinKlasse> GetAsync(int id)
        {
            try
            {
                return await _dbContext.TreinKlasses.Where(b => b.Id == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            { throw new Exception("error DAO Stad"); }
        }

        public Task Update(TreinKlasse entity)
        {
            throw new NotImplementedException();
        }
    }
}
