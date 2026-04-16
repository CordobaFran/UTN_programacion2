namespace dominio.Figura;

public class Figura
{
    private string? _nombre;
    public string? Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    
    private string? _apellido;
    public string? Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }
    
    private double _perimetro;
    public double Perimetro
    {
        get { return _perimetro; }
        set { _perimetro = value; }
    }
    
    private double _area;
    public double Area
    {
        get { return _area; }
        set { _area = value; }
    }
    
}