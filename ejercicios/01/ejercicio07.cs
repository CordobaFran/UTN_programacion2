Ninja ninjaUno = new Ninja("saltador", "piernas", 200, 500);
Ninja ninjaDos = new Ninja("golpeador", "manos", 150, 200);


System.Console.WriteLine(ninjaUno.Saltar(4));
System.Console.WriteLine(ninjaDos.Ataque());

public class Ninja
{
    private string _arteMarcial;
    public string ArteMarcial
    {
        get { return _arteMarcial; }
        set { _arteMarcial = value; }
    }
    private string _arma;
    public string Arma
    {
        get { return   _arma; }
        set {  _arma = value; }
    }
    
    private int _fuerza;
    public int Fuerza
    {
        get { return _fuerza; }
        set { _fuerza = value; }
    }
    
    private int _salto;
    public int Salto
    {
        get { return _salto; }
        set { _salto = value; }
    }

    
    public Ninja(string arte, string arma, int fuerza, int salto)
    {
        this.ArteMarcial = arte;
        this.Arma = arma;
        this.Fuerza = fuerza;
        this.Salto = salto;
    }
    public int Saltar(int multiplicador)
    {
        return this.Salto * multiplicador;
    }

    public string Ataque()
    {
        return $"Arma: {this.Arma}, Arte Marcial {this.ArteMarcial}";
    }
}