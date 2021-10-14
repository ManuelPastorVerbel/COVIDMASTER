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
    public class EliminarPersonalAseoModel : PageModel
    {
        
         private static IRepositorioPersonal_Aseo _repoPersonalAseo = new RepositorioPersonal_Aseo(new Persistencia.AppContext());


        
        [BindProperty]

        public Personal_Aseo personalAseo { get; set; }

         public IActionResult OnGet(int idPersonal_Aseo)
        {
            personalAseo = _repoPersonalAseo.GetPersonal_Aseo(idPersonal_Aseo);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoPersonalAseo.DeletePersonal_Aseo(personalAseo.id);
            return RedirectToPage("./ListaPersonalAseo");
        }
    }
}
