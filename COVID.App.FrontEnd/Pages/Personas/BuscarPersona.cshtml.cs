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
    public class BuscarPersonaModel : PageModel
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        
        [BindProperty]

        public IQueryable<Persona> Personas {get;set;}

        

        public IActionResult OnGet(string FiltroBusqueda)
        {
          
         
        
         Personas=_repoPersona.GetAllPersonaPorFiltro(FiltroBusqueda);
         
          if(Personas==null)
            {
                return RedirectToPage("/Index");
            }else
            return Page(); 

        }
    }
}
