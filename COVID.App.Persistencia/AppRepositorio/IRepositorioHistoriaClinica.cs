using System.Collections.Generic;
using System.Linq;
using COVID.App.Dominio;

namespace COVID.App.Persistencia
{
    public interface IRepositorioHistoriaClinica
    {
      
       

        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaclinica);
       
       HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaclinica);
        
        void DeleteHistoriaClinica(int idHistoriaClinica);
     

        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);  
    }

}