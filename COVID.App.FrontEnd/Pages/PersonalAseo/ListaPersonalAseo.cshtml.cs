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
    public class ListaPersonalAseoModel : PageModel
    {
        private static IRepositorioPersonal_Aseo _repoPersonalAseo = new RepositorioPersonal_Aseo(new Persistencia.AppContext());
         [BindProperty]
         
        public IEnumerable<Personal_Aseo> Personal_Aseo {get;set;}
        
       


        public IActionResult OnGet()
        {
            Personal_Aseo = _repoPersonalAseo.GetAllPersonal_Aseo();
          return Page(); 
        }
        
    }
}
