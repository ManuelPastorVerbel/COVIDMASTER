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
    public class EliminarDirectivooModel : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());


        
        [BindProperty]
        public Directivo directivo {get;set;}

        public IActionResult OnGet(int idDirectivo)
        {
            directivo = _repoDirectivo.GetDirectivo(idDirectivo);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoDirectivo.DeleteDirectivo(directivo.id);
            return RedirectToPage("./ListaDirectivo");
        }
   
    }
}
