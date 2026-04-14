Guardia unGuardia = new Guardia("Franco", "Cordoba");
System.Console.WriteLine(unGuardia.Presentarse());

public class Persona
{
   private string nombre;
   public string Nombre
   {
    get { return nombre; }
    set { nombre = value; }
   }

   private string apellido;
   public string Apellido
   {
    get { return apellido; }
    set { apellido = value; }
   }

   public virtual string Presentarse()
    {
        return $"mi nombre es {this.nombre} {this.apellido}";
    }

    public Persona()
    {
        
    }

    public Persona(string nombre, string apellido)
    {
        this.nombre = nombre;
        this.apellido = apellido;
    }
        
}

public class Guardia : Persona
{
    public Guardia(string nombre, string apellido)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
    }
    public override string Presentarse()
    {
        return $"Hola ni nombre es {this.Nombre} {this.Apellido} y soy el guardia";
    }
}

public class Visitante : Persona
{
    public Visitante(string nombre, string apellido)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
    }
    public override string Presentarse()
    {
        return $"Hola ni nombre es {this.Nombre} {this.Apellido} y soy un visitante";
    }
}