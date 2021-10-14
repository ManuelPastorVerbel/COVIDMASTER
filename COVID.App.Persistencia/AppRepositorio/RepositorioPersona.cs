using System.Collections.Generic;
using System.Linq;
using COVID.App.Dominio;

namespace COVID.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona 
    {
        private static AppContext  _appContext;
     
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
       
       IQueryable<Persona> IRepositorioPersona.GetAllPersonaPorFiltro(string FiltroBusqueda) 
       {        
           IQueryable<Persona> personasencontradas= _appContext.Personas.Where(p => p.nombre.Contains(FiltroBusqueda));
                     
            return personasencontradas;                             
       }
       IQueryable<Persona> IRepositorioPersona.GetAllPersona()
       {
           return  _appContext.Personas;
       }  
       Persona IRepositorioPersona.GetPersona(int idPersona)
        {
           
            var PersonaEncontrado= _appContext.Personas.FirstOrDefault(p => p.id == idPersona);
            return PersonaEncontrado;
        }

    }
}