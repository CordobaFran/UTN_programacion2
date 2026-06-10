namespace classes.Singleton;
public class Presidente
{
    //atributos
    private string? _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string? _apellido;
    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    // instancia única
    private static Presidente? _instance;

    // constructor privado
    private Presidente()
    {}

    public static Presidente GetPresidente()
    {
        if (_instance == null)
        {
            _instance = new Presidente();
        }
        return _instance;
    }

    public static void SetPresidente(string nombre, string apellido)
    {
        if (_instance == null)
        {
            _instance = new Presidente();
        }
        
        _instance.Nombre = nombre;
        _instance.Apellido = apellido;
    }
}