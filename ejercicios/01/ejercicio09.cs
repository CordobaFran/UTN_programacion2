
Persona unaPersona = new Persona("Franco", "Cordoba");
Visitante unVisitante = new Visitante("Carlos", "Diaz");
Guardia unGuardia = new Guardia("Guillermo", "Coria");

System.Console.WriteLine(unaPersona.Nombre + " " + unaPersona.Apellido);
System.Console.WriteLine(unVisitante.Nombre + " " + unVisitante.Apellido);
System.Console.WriteLine(unGuardia.Nombre + " " + unGuardia.Apellido);
public class Persona
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    
    private string _apellido;
    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    public Persona()
    {
        
    }
    
    public Persona(string nombre, string apellido)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
    }
}

public class Visitante : Persona
{
    public Visitante()
    {}
    public Visitante(string nombre, string apellido)
    {
        base.Nombre = nombre;
        base.Apellido = apellido;
    }
}
public class Guardia : Persona
{
    public Guardia()
    {
        
    }
    public Guardia(string nombre, string apellido)
    {
        base.Nombre = nombre;
        base.Apellido = apellido;
    }
}