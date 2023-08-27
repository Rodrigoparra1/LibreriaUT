using LibreriaUT.Data;
using LibreriaUT.Domain.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace LibreriaUT.Web.Pages.Author
{
    public partial class AuthorOverview
    {
        //Injectar el contexto de datos

        [Inject]
        public EditorialUTDbContext Db { get; set; }
        public List<Autor>? Autores { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //Task.Delay(2000);
            Autores = await Db.Autores
                .Include(a => a.Libros)
                .ToListAsync();

        }

    }
}
