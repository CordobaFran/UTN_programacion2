
Alumno unaPersona = new Alumno();
unaPersona.SetNombre("Franco");
unaPersona.SetApellido("Cordoba");
unaPersona.SetEmail("francocordobafs@gmail.com");
unaPersona.Legajo = "1234";

System.Console.WriteLine(unaPersona.Saludar());


public abstract class Persona
{
    private string nombre;
    private string apellido;
    private string email;

    public string GetNombre()
    {
        return nombre;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string getApellido()
    {
        return apellido;
    }
    public void SetApellido(string apellido)
    {
        this.apellido = apellido;
    }

    public string getEmail()
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

public class Alumno : Persona
    {
        public string Legajo {get; set;}
        public float Promedio {get; set;}

        public override string Saludar()
        {
            return $"Hola mi nombre es {this.GetNombre()} {this.getApellido()} y mi legajo es {Legajo}";
        }
    }