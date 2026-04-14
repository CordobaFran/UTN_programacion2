Visitante unaPersona = new Visitante("Franco", "Cordoba", 36784909);
Guardia unGuardia = new Guardia("Sargento", "Cabral");

Console.WriteLine(unGuardia.ControlarDocumento(unaPersona));

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
        return $"mi nombre es {this.Nombre} {this.Apellido} y soy el Guardia";
    }

    public string ControlarDocumento(Visitante unVisitante)
    {
        return $"Adelante persona {unVisitante.Nombre} {unVisitante.Apellido} con dni {unVisitante.Dni}";
    }
}

public class Visitante : Persona
{
    private int dni;
    public int Dni
    {
        get { return dni; }
        set { dni = value; }
    }

    public Visitante(string nombre, string apellido, int dni)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Dni = dni;
    }
    public override string Presentarse()
    {
        return $"mi nombre es {this.Nombre} {this.Apellido} y soy un visitante";
    }

}