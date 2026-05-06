namespace clases.Vagones;

public abstract class Vagones
{
    private int _largo;
    public int Largo
    {
        get { return _largo; }
        set { _largo = value; }
    }
    
    private int _ancho;
    public int Ancho
    {
        get { return _ancho; }
        set { _ancho = value; }
    }
    
    private float _cargaMaxima;
    public float CargaMaxima
    {
        get { return _cargaMaxima; }
        set { _cargaMaxima = value; }
    }

    public Vagones(int largo, int ancho)
    {
        _largo = largo;
        _ancho = ancho;
    }
    
}