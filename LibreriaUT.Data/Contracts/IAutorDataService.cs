using LibreriaUT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUT.Data.Contracts
{
    public interface IAutorDataService
    {
        Task<IEnumerable<Autor>>GetAllAutores();
        Task<Autor>GetAutorById(int id);
        Task Add(Autor autor);
    }
}
