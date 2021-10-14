using System;
using System.Collections.Generic;

namespace COVID.App.Dominio 
{
    public class Curso
    {
       public int id { get; set; }
       

       public string nombre { get; set; }
       public int cantidad_inscritos { get; set; }
       public string Dia { get; set; }
       public int DuracionClase { get; set;}
       public string hora { get; set; }
       public System.Collections.Generic.List<CursoEstudiante> cursoestudiante { get; set; }
       public System.Collections.Generic.List<CursoProfesor> cursoprofesor { get; set; }
       public System.Collections.Generic.List<CursoSalon> cursosalon { get; set; }
    }
}