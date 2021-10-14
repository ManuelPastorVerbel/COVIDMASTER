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
    public class EliminarModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        public Profesor profesor{get;set;}

        public IActionResult OnGet(int idProfesor)
        {
            profesor = _repoProfesor.GetProfesor(idProfesor);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoProfesor.DeleteProfesor(profesor.id);
            return RedirectToPage("./List");
        }
    }
}
