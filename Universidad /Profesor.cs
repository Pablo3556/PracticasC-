namespace Universidad;

class Profesor{
    public string CodProfesor{get;set;}
     public string Nombre {get;set;}
      public string Apellidos{get;set;}
    
    public List<string> AsignaturasImpartidas{get;set;} = new List<string>();

    public Profesor(string codProfesor,string nombre,string apellidos){

        CodProfesor =codProfesor;
        Nombre=nombre;
        Apellidos=apellidos;
    }
}