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
    public class EliminarEstudianteModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        
        [BindProperty]
        public Estudiante estudiante{get;set;}

        public IActionResult OnGet(int idEstudiante)
        {
            estudiante = _repoEstudiante.GetEstudiante(idEstudiante);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoEstudiante.DeleteEstudiante(estudiante.id);
            return RedirectToPage("./ListaEstudiantes");
        }
   
    }
}
