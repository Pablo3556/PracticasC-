
namespace Universidad;
class Alumnos{
    public string Expediente{get;set;}
    public string Nombre{get;set;}
    public string Apellidos{get;set;}

     public List<string> Asignaturas {get;set;} =new List<string>();

     public Alumnos(string expediente,string nombre,string apellidos){
        Expediente =expediente;
        Nombre =nombre;
        Apellidos=apellidos;

     }
     
}