using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

namespace Universidad;

class Program{
 

    static void Main(string[] args){
    var Operaciones = new Operaciones();
    int opcion;
    
    do{
        Console.WriteLine("1.Insertar  Alumno");
        Console.WriteLine("2.Insertar Profesor");
        Console.WriteLine("3.Consultar Informacion");
        Console.WriteLine("4.Matricular Alumno en una Asignatura");
        Console.WriteLine("5.Asignar Profesor Asignatura");
        Console.WriteLine("6.Consultar Asignatura Alumno");
        Console.WriteLine("7.Consultar Asignaturas Profesor");
         Console.WriteLine("7.Salir");


        Console.WriteLine("Dime la opcion");
         opcion = Convert.ToInt16(Console.ReadLine());

        switch(opcion){
            case 1:
             Operaciones.insertarAlumno();
                break;
            case 2:
             Operaciones.insertarProfesor();
                break;
            case 3:
                Operaciones.consultarInformacion();
                break;
            case 4:
                Operaciones.matricularAlumno();
                break;
            case 5:
                Operaciones.AsignarProfesor();
                break;
            case 6:
                Operaciones.consultarAsignaturasAlumno();
                break;
            case 7:
                Operaciones.consultarAsignaturasProfesor();
                break;
           
        }
    }while(opcion !=8);
   
   

    
    }
   
    
    

}