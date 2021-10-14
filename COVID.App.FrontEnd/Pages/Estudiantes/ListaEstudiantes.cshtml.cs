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
    public class ListaEstudiantesModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
         [BindProperty]
         
        public IEnumerable<Estudiante> Estudiantes {get;set;}
        
       


        public IActionResult OnGet()
        {
            Estudiantes = _repoEstudiante.GetAllEstudiantes();
          return Page(); 
        }
        
    }
}
    

