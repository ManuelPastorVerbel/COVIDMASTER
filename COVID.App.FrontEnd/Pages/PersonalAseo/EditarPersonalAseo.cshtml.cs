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
    public class EditarPersonalAseoModel : PageModel
    {
        private static IRepositorioPersonal_Aseo _repoPersonalAseo = new RepositorioPersonal_Aseo(new Persistencia.AppContext());


        
        [BindProperty]

        public Personal_Aseo personalAseo { get; set; }

        public IActionResult OnGet(int? idPersonal_Aseo)
        {
          if(idPersonal_Aseo.HasValue)
            {
            personalAseo =  _repoPersonalAseo.GetPersonal_Aseo(idPersonal_Aseo.Value);
            }else
            {
                personalAseo=new Personal_Aseo();
            }
            if(personalAseo == null)
            {
                return RedirectToPage("./ListaPersonalAseo");
            }else
            return Page(); 
             
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();                
            }else
                {
                    if(personalAseo.id>0)
                    {
                    personalAseo = _repoPersonalAseo.UpdatePersonal_Aseo(personalAseo);
                    return RedirectToPage("./ListaPersonalAseo");
                    }else
                    {
                    _repoPersonalAseo.AddPersonal_Aseo(personalAseo);
                     }     
                    return RedirectToPage("./ListaPersonalAseo");
                }
        
  
        }
    }
}
