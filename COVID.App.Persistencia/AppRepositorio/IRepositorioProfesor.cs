using System.Collections.Generic;
using COVID.App.Dominio;
using System.Linq;

namespace COVID.App.Persistencia 
{
    public interface  IRepositorioProfesor
    {
        
         //GetAllProfesores
        
        IQueryable<Profesor> GetAllProfesores();
        /// detalles de profesor 
       
        //AddProfesor
        Profesor AddProfesor(Profesor profesor);
        //UpdateProfesor
        Profesor UpdateProfesor(Profesor profesor);
        //DeleteProfesor
        void DeleteProfesor(int idProfesor);
        //GetProfesor
        Profesor GetProfesor(int idProfesor);
        //GetProfesor
        
    }
}