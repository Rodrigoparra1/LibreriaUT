using LibreriaUT.Data;
using LibreriaUT.Data.Contracts;
using LibreriaUT.Domain.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace LibreriaUT.Web.Pages.Author
{
    public partial class AuthorOverview
    {
        //Injectar el contexto de datos

        [Inject]
       public IAutorDataService? AutorDataService { get; set; }
        public List<Autor>? Autores { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.Autores = (await AutorDataService.GetAllAutores()).ToList();
        }

    }
}
