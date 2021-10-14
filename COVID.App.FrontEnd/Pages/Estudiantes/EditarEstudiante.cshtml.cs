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
    public class EditarEstudianteModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        
        [BindProperty]

        public Estudiante estudiante { get; set; }

         public IActionResult OnGet(int? idEstudiante)
        {
            if(idEstudiante.HasValue)
            {
            estudiante = _repoEstudiante.GetEstudiante(idEstudiante.Value);
            }else
            {
                estudiante=new Estudiante();
            }
            if(estudiante==null)
            {
                return RedirectToPage("./ListaEstudiantes");
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
                    if(estudiante.id>0)
                    {
                    estudiante = _repoEstudiante.UpdateEstudiante(estudiante);
                    return RedirectToPage("./ListaEstudiantes");
                    }else
                    {
                    _repoEstudiante.AddEstudiante(estudiante);
                     }     
                    return RedirectToPage("./ListaEstudiantes");
                }
        }

    }
}
