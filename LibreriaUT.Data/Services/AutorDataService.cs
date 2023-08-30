using LibreriaUT.Data.Contracts;
using LibreriaUT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUT.Data.Services
{
    public class AutorDataService : IAutorDataService
    {
        private readonly EditorialUTDbContext _db;

        public AutorDataService(IDbContextFactory<EditorialUTDbContext> contextFactory)
        {
            _db = contextFactory.CreateDbContext();   
        }

        public Task Add(Autor autor)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Autor>> GetAllAutores()
        {
           return await _db.Autores
                .Include(a => a.Libros)
                .ToListAsync();
        }

        public async Task<Autor> GetAutorById(int id)
        {
           
           return await _db.Autores.FirstOrDefaultAsync(a => a.Id.Equals(id));
        }
    }
}
