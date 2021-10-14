using System;
using COVID.App.Dominio;
using COVID.App.Persistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COVID.App.Consola
{
    class Program
    {
       private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
       private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
       private static IRepositorioHistoriaClinica _repoHistoriaClinica = new RepositorioHistoriaClinica(new Persistencia.AppContext());

       private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        
       private static IRepositorioSalon _repoSalon =new RepositorioSalon(new Persistencia.AppContext());

       private static IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());
        static void Main(string[] args)

        {
            bool salir = false;
            while (!salir)
            {
               Console.WriteLine("                          Bienvenido                                   ");
               Console.WriteLine("                Asistente para seguimiento COVID-19                     ");
               Console.WriteLine("-----------------------------------------------------------------------");
               Console.WriteLine("                        MENÚ PRINCIPAL                             ");
               Console.ForegroundColor = ConsoleColor.White;
               Console.Write("                           1.Registrar Profesor \n");
                Console.Write("                           2.Registrar Estudiante\n");
                Console.Write("                           3.consultar Persona\n");
                Console.Write("                           4.crear Salon\n"); 
                Console.Write("                           5.crear sede\n");
                Console.Write("                           6.Salir\n");            
                     
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                int opcion = Convert.ToInt32(Console.ReadLine());

                //métodos son acciones, las propiedades son valores
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("nombre :");
                        string nombre=Console.ReadLine();
                        Console.WriteLine("apellido :");
                        string apellido=Console.ReadLine();
                        Console.WriteLine("edad :");
                        int edad=Convert.ToInt32(Console.ReadLine());
                       
                        
                        Console.WriteLine("departamento :");
                        string departamento=Console.ReadLine();
                        Console.WriteLine("asignatura :");
                        string asignatura=Console.ReadLine();
                        Console.WriteLine("Historia Clinica");
                        Console.WriteLine("cuales Sintomas tienes :");
                        string Sintoma2=Console.ReadLine();
                        DateTime fecha2=DateTime.Now;
                        var historiaclinica=new HistoriaClinica()
                        {
                            Sintoma =Sintoma2,
                            fecha=fecha2
                        };
                        var profesor =new Profesor()
                        {
                            nombre=nombre,
                            apellido=apellido,
                            edad=edad,
                            estado=Estado.negativo,
                            historiaclinica=historiaclinica,
                            departamento=departamento,
                            asignatura=asignatura
                        };
                        _repoProfesor.AddProfesor(profesor);
                        
                        

                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        
                        break;

                    case 2:
                        Console.WriteLine("nombre :");
                        string nombreEstudiante=Console.ReadLine();
                        Console.WriteLine("apellido :");
                        string apellidoEstudiante=Console.ReadLine();
                        Console.WriteLine("edad :");
                        int edadEstudiante=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("carrera :");
                        string carrera=Console.ReadLine();
                        Console.WriteLine("semestre :");
                        int semestre=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Historia Clinica");
                        Console.WriteLine("cuales Sintomas tienes :");
                        string Sintoma3=Console.ReadLine();
                        DateTime fecha3=DateTime.Now;
                        var historiaclinicaE=new HistoriaClinica()
                        {
                            Sintoma =Sintoma3,
                            fecha=fecha3
                        };
                        var estudiante =new Estudiante()
                        {
                            nombre=nombreEstudiante,
                            apellido=apellidoEstudiante,
                            edad=edadEstudiante,
                            estado=Estado.negativo,
                            historiaclinica=historiaclinicaE,
                            carrera=carrera,
                            semestre=semestre
                        };
                        _repoEstudiante.AddEstudiante(estudiante);                                            
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("id a Buscar");
                        int idPersona=Convert.ToInt32(Console.ReadLine());
                       var persona =_repoPersona.GetPersona(idPersona);
                       Console.WriteLine(persona.nombre);
                       Console.WriteLine(persona.apellido);
                       Console.WriteLine(persona.edad);
                       HistoriaClinica h = persona.historiaclinica;
                       Console.WriteLine(h.Sintoma);
                       Console.WriteLine(h.fecha);

                        
                        
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Chao");
                        AdicionarSAlon();

                        Console.ReadKey();
                        break;
                    case 5:
                        CrearSede();
                        Console.ReadKey();
                        break;
                    case 6:
                    salir = true;
                    break;
                    default:
                    Console.WriteLine("Elige una opcion entre 1 y 4");
                    break;

                    
                   

                }
            }
        }

        public static void AdicionarSAlon()
        {
          var salon = new Salon()
          {
              aforo =15,
              numerosalon=7,
              unidad = "bolivar",
              cursosalon= new System.Collections.Generic.List<CursoSalon>{
                  new CursoSalon{},
                  new CursoSalon{}
              }

          };
         _repoSalon.AddSalon(salon);
        }
        public static void CrearSede(){
            var sede= new Sede()
                    {
                      nombre_sede="carlos magno",
                      cantidad_salones=5,
                      salones= new System.Collections.Generic.List<Salon>{
                          new Salon
                          {aforo=15,numerosalon=8,unidad="reto",cursosalon= new System.Collections.Generic.List<CursoSalon>
                                                                                     {
                                                                                      new CursoSalon{},
                                                                                      new CursoSalon{}}
                                   }
                                                                     }
                    };
            _repoSede.AddSede(sede);
        }
    }
}
