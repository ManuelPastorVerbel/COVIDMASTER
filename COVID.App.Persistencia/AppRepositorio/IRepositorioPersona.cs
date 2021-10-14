using System.Collections.Generic;
using System.Linq;
using COVID.App.Dominio;

namespace COVID.App.Persistencia
{
    public interface IRepositorioPersona
    {
        //Buscar persona por filtro
     
     IQueryable<Persona> GetAllPersonaPorFiltro(string FiltroBusqueda);
     IQueryable<Persona> GetAllPersona();
     Persona GetPersona(int idPersona);
    
    }
}


