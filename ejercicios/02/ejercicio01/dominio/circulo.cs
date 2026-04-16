using dominio.Figura;

public class Circulo : Figura
{
    private float _diametro;
    public float Diametro
    {
        get { return _diametro; }
        set { _diametro = value; }
    }
    
    
    public double CalcularArea()
    {
        float radio = _diametro/2;
        return Math.PI * Math.Pow( radio, 2);
    }

    public double CalcularPerimetro()
    {
        return Math.PI * _diametro;
    }

    public Circulo(int diametro)
    {
        this.Diametro = diametro;
        this.Area = this.CalcularArea();
        this.Perimetro = this.CalcularPerimetro();
    }
}