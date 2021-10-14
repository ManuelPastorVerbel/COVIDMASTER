using System.Collections.Generic;
using System.Linq;
using COVID.App.Dominio;

namespace COVID.App.Persistencia

{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica

    {
        private static AppContext  _appContext;


        public RepositorioHistoriaClinica(AppContext appContext)
        {
            _appContext = appContext;
        }
      HistoriaClinica IRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica historiaclinica)
        {
            var HistoriaClinicaAdicionada = _appContext.HistoriaClinicas.Add(historiaclinica);
            _appContext.SaveChanges();

            return HistoriaClinicaAdicionada.Entity;
        }
        HistoriaClinica IRepositorioHistoriaClinica.UpdateHistoriaClinica(HistoriaClinica historiaclinica)
        {
            var HistoriaClinicaEncontrada =_appContext.HistoriaClinicas.FirstOrDefault(h => h.id == historiaclinica.id);
            if(HistoriaClinicaEncontrada!=null)
            {
                HistoriaClinicaEncontrada.Sintoma=historiaclinica.Sintoma;
                HistoriaClinicaEncontrada.fecha=historiaclinica.fecha;
                
                
                
                _appContext.SaveChanges();

            }
            return HistoriaClinicaEncontrada;

        }

        void IRepositorioHistoriaClinica.DeleteHistoriaClinica(int idHistoriaClinica)
        {
          var HistoriaClinicaEncontrada =_appContext.HistoriaClinicas.FirstOrDefault(h => h.id == idHistoriaClinica);
          if (HistoriaClinicaEncontrada == null)
              return;
            _appContext.HistoriaClinicas.Remove(HistoriaClinicaEncontrada);
            _appContext.SaveChanges();
          
        }

        HistoriaClinica IRepositorioHistoriaClinica.GetHistoriaClinica(int idHistoriaClinica)
        {
           
            var HistoriaClinicaEncontrada= _appContext.HistoriaClinicas.FirstOrDefault(h => h.id == idHistoriaClinica);
            return HistoriaClinicaEncontrada;
        }

        

    }

}