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
    public class DetallePersonalAseoModel : PageModel
    {
        private static IRepositorioPersonal_Aseo _repoPersonalAseo = new RepositorioPersonal_Aseo(new Persistencia.AppContext());
        
        public Personal_Aseo personal_aseo { get; set; }

        public IActionResult OnGet(int idPersonal_Aseo)
    
        {
          
            personal_aseo =_repoPersonalAseo.GetPersonal_Aseo(idPersonal_Aseo);
            
            if(personal_aseo == null)
            {
                return RedirectToPage("./ListaPersonalAseo");
            }else
            return Page();        
        }
       
    }
}
