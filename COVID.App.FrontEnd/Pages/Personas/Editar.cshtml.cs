using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using COVID.App.Persistencia;
using COVID.App.Dominio;
namespace COVID.App.Frontend.Pages
{
    public class EditarModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        public Profesor profesor{get;set;}
        
        public Profesor profesorlista { get; set; }

        public IActionResult OnGet(int? idProfesor)
        {
            if(idProfesor.HasValue)
            {
            profesor = _repoProfesor.GetProfesor(idProfesor.Value);
            }else
            {
                profesor=new Profesor();
            }
            if(profesor==null)
            {
                return RedirectToPage("./List");
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
                    if(profesor.id>0)
                    {
                    _repoProfesor.UpdateProfesor(profesor);
                   
                    }else
                    {
                    _repoProfesor.AddProfesor(profesor);
                     }     
                    return RedirectToPage("/Index");
                }
        }


    }
}
