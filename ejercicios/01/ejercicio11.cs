Visitante unaPersona = new Visitante("Franco", "Cordoba");
Guardia unGuardia = new Guardia("Sargento", "Cabral");

unaPersona.Dni = 36784909;

System.Console.WriteLine(unGuardia.ControlarDocumento(unaPersona.Dni));

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

    public string ControlarDocumento(int dni)
    {
        return $"Adelante persona con dni {dni}";
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

    public Visitante(string nombre, string apellido)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
    }
    public override string Presentarse()
    {
        return $"mi nombre es {this.Nombre} {this.Apellido} y soy un visitante";
    }

}