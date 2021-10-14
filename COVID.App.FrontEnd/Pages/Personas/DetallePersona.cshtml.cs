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
    public class DetallePersonaModel : PageModel
    {

        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        [BindProperty]
        public Persona Persona { get; set; }

        public IActionResult  OnGet(int idPersona)
        {
            
            Persona =_repoPersona.GetPersona(idPersona);
            
            if(Persona==null)
            {
                return RedirectToPage("./List");
            }else
            return Page();

        }
    }
}
