
Persona unaPersona = new Persona();
unaPersona.Nombre = "Franco";
unaPersona.Apellido = "Cordoba";

System.Console.WriteLine(unaPersona.Nombre + " " + unaPersona.Apellido);

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
}