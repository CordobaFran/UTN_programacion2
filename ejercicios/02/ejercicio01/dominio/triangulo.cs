using dominio.Figura;

public class Triangulo : Figura
{
    private int _lado1;
    public int Lado1
    {
        get { return _lado1; }
        set { _lado1 = value; }
    }
    private int _lado2;
    public int Lado2
    {
        get { return _lado2; }
        set { _lado2 = value; }
    }
    private int _lado3;
    public int Lado3
    {
        get { return _lado3; }
        set { _lado3 = value; }
    }
    
    public double CalcularArea()
    {
     	float s = (_lado1 + _lado2 + _lado3)/2;
	    return Math.Sqrt(s*(s-_lado1)*(s-_lado2)*(s-_lado3));
    }

    public int CalcularPerimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }

    public Triangulo(int lado1, int lado2, int lado3)
    {
        this.Lado1 = lado1;
        this.Lado2 = lado2;
        this.Lado3 = lado3;

        this.Perimetro = CalcularPerimetro();
        this.Area = CalcularArea();

    }
}