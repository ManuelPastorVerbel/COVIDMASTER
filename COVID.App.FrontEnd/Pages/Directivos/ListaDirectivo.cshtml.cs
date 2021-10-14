using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using COVID.App.Persistencia;
using COVID.App.Dominio;

namespace COVID.App.FrontEnd.Pages
{
    public class ListaDirectivoModel : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
         [BindProperty]
        public IEnumerable<Directivo> Directivos {get;set;}
        
        public IActionResult OnGet()
        {
            Directivos = _repoDirectivo.GetAllDirectivos();
          return Page(); 
        }
    }
}
