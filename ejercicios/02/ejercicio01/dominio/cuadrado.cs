using dominio.Figura;

public class Cuadrado : Figura
{
    private int _lado;
    public int Lado
    {
        get { return _lado; }
        set { _lado = value; }
    }

    public double CalcularArea()
    {
        return Math.Pow(Lado, 2);
    }

    public int CalcularPerimetro()
    {
        return Lado * 4;
    }
    
    public Cuadrado(int lado)
    {
        this.Lado = lado;
        this.Perimetro = CalcularPerimetro();
        this.Area = CalcularArea();
    }
}