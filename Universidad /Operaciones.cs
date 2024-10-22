using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Universidad;
class Operaciones
{
    private List<Alumnos> alumnos = new List<Alumnos>();
    private List<Profesor> profesores = new List<Profesor>();
    
    
     public void insertarAlumno(){
         Console.WriteLine("Dime el expediente");
         var expediente = Console.ReadLine();
        Console.WriteLine("Dime el nombre");
         var nombre = Console.ReadLine();
         Console.WriteLine("Dime los apellidos");
         var apellidos =Console.ReadLine();

         var alumno = new Alumnos(expediente,nombre,apellidos);
            alumnos.Add(alumno);
        
        Console.WriteLine("Dime las asignaturas a annadir(escriba fin para finalizar)");
        while(true){
            var asignatura =Console.ReadLine();
            if(asignatura=="fin"){
                break;
            }
            alumno.Asignaturas.Add(asignatura);
        }


    }
   
   
   
    public void insertarProfesor(){
            Console.WriteLine("Dime el CodProfesor");
            var codProfesor = Console.ReadLine();
            Console.WriteLine("Dime el nombre ");
            var nombre = Console.ReadLine();
             Console.WriteLine("Dime los apellidos ");
            var apellidos = Console.ReadLine();
            
        var profesor = new Profesor(codProfesor,nombre,apellidos);
        profesores.Add(profesor);
             Console.WriteLine("Dime las asignaturas a annadir(escriba fin para finalizar)");
       
        while(true){
            var asignaturaImp =Console.ReadLine();
            if(asignaturaImp=="fin"){
                break;
            }
            profesor.AsignaturasImpartidas.Add(asignaturaImp);
         }
    }
   
   
   
    public void consultarInformacion(){
        Console.WriteLine("Alumnos: \n");
        foreach(var alumno in alumnos){
        Console.WriteLine("Expediente:{0},Nombre{1},Apellidos:{2},Asignaturas: \n",alumno.Expediente,alumno.Nombre,alumno.Apellidos);
        foreach(var asignatura in alumno.Asignaturas){
            Console.WriteLine(asignatura);
        }
    }
        Console.WriteLine("PROFESORES: \n");
        foreach(var profesor in profesores){
            Console.WriteLine("CodProfesor:{0},Nombre:{1},Apellidos:{2}\n",profesor.CodProfesor,profesor.Nombre,profesor.Apellidos);
            foreach(var asignatura in profesor.AsignaturasImpartidas){
            Console.WriteLine(asignatura);
        }
        }


    }
    public void matricularAlumno(){
       
        Console.WriteLine("Dime el codigo del alumno");
        var expediente = Console.ReadLine();
            foreach(var alumno in alumnos ){
                if(alumno.Expediente ==expediente){
                    Console.WriteLine("Dime la asignatura que se quiere matricular");
                    var asignatura = Console.ReadLine();
                    //recorrer la lista para comprobar si esta 
                    alumno.Asignaturas.Add(asignatura);
                }
            }
    }
     public void AsignarProfesor(){
            Console.WriteLine("Dime el codigo del profesor");
            var codigo =Console.ReadLine();

            foreach(var profesor in profesores){
                if(profesor.CodProfesor == codigo){
                    Console.WriteLine("Dime la asignatura que se quiere asignar");
                    var asignatura = Console.ReadLine();
                    //recorrer la lista para comprobar si esta 
                    profesor.AsignaturasImpartidas.Add(asignatura);
                }
            }
    }

    public void consultarAsignaturasAlumno(){
         Console.WriteLine("Dime el expediente del alumno");
        var expediente = Console.ReadLine();
         
          foreach(var alumno in alumnos ){
                if(alumno.Expediente ==expediente){
                    foreach(var asignatura in alumno.Asignaturas){
                        Console.WriteLine(asignatura);
                    }        
   
                }
            }
    }

    public void consultarAsignaturasProfesor(){
        Console.WriteLine("Dime el codigo del profesor");
        var codProfesor = Console.ReadLine();
         
          foreach(var profesor in profesores ){
                if(profesor.CodProfesor==codProfesor){
                    foreach(var asignatura in profesor.AsignaturasImpartidas){
                        Console.WriteLine(asignatura);
                    }        
   
                }
            }
    }
}

