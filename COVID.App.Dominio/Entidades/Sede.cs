using System;
using System.Collections.Generic;

namespace COVID.App.Dominio 
{
    public class Sede
    {
        public int id { get; set; }
        public string nombre_sede { get; set; }
        public int cantidad_salones {get; set;}
        public System.Collections.Generic.List<Salon> salones { get; set; }

        

    }
}
