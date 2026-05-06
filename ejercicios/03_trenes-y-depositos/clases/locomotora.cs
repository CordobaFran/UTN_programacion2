namespace clases.Locomotora;

public class Locomotora
{
    private float _peso;
    public float Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }

    private float _pesoMaxArrastre;
    public float PesoMaxArrastre
    {
        get { return _pesoMaxArrastre; }
        set { _pesoMaxArrastre = value; }
    }
    
    private float _velocidadMax;
    public float VelocidadMax
    {
        get { return _velocidadMax; }
        set { _velocidadMax = value; }
    }
    private float _arrastreUtil;
    public float ArrastreUtil
    {
        get { return _arrastreUtil; }
        set { _arrastreUtil = _pesoMaxArrastre - _peso; }
    }

    public Locomotora(float peso, float pesoMaxArrastre, float velocidadMax)
    {
        _peso = peso;
        _pesoMaxArrastre = pesoMaxArrastre;
        _velocidadMax = velocidadMax;
    }
    
}