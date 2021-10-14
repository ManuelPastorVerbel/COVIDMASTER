using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using COVID.App.Persistencia;
using COVID.App.Dominio;


namespace COVID.App.FrontEnd.pages
{
    public class ListModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        
        public IQueryable <Profesor> Profesores {get;set;}
        
        
         
        public void OnGet()
        {
           
            Profesores = _repoProfesor.GetAllProfesores();
            
           
        }
        
    }
}
