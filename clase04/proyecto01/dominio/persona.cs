namespace proyecto01.Dominio;

public abstract class Persona
{
    private string nombre;
    private string apellido;
    private string email;

    public Persona()
    {
        
    }
    public Persona(string nombre, string apellido, string email)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
    }

    public string GetNombre()
    {
        return nombre;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string GetApellido()
    {
        return apellido;
    }
    public void SetApellido(string apellido)
    {
        this.apellido = apellido;
    }

    public string GetEmail()
    {
        return email;
    }
    public void SetEmail(string email)
    {
        this.email = email;
    }

    public virtual string Saludar()
    {
        return $"Hola mi nombre es {this.nombre} {this.apellido} y mi email es {this.email}";
    }
}