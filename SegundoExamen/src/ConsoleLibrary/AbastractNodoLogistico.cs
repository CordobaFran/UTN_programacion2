namespace ConsoleLibrary;

public abstract class NodoLogistico
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    private string _direccion;
    public string Direccion
    {
        get { return _direccion; }
        set { _direccion = value; }
    }
    

    public NodoLogistico(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
    }

    public string GetDireccion()
    {   
        return _direccion;
    }
    
    public abstract int GetTotalCamiones();
    public abstract float TiempoMedioEntrega();
}