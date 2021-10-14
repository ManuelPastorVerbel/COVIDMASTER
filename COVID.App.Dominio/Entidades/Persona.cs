using System;
using System.ComponentModel.DataAnnotations;

namespace COVID.App.Dominio 
{
    public class Persona
    {
        public int id { get; set; }
         [Required]
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }

        public Estado estado { get; set; }
         
        public HistoriaClinica historiaclinica { get; set; }
        

        
    }
}