using System;

namespace COVID.App.Dominio 
{
    public class Profesor : Persona
    {
        public string departamento { get; set; }
        public string asignatura { get; set; }
        public System.Collections.Generic.List<CursoProfesor> cursoprofesor { get; set; }
        
    }
}