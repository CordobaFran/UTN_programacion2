namespace Dominio.Dron;
using Dominio.Herramienta;
public class Dron
{
    private double _velocidad = 5;
    public double Velocidad
    {
        get { return _velocidad; }
        set { _velocidad = value; }
        
    }

    private double _altura = 100;
    public double Altura
    {
        get { return _altura; }
        set { _altura = value; }
    }

    private int _carga = 200;
    public int Carga
    {
        get { return _carga; }
        set { _carga = value; }
    }

    private Herramienta? _tipoHerramienta;
    public Herramienta? TipoHerramienta
    {
        get { return _tipoHerramienta; }
        set { _tipoHerramienta = value; }
    }
    
    public string PrintDron()
    {
        return $"Caracteristicas del Dron. Velocidad: {this.Velocidad}, Altura: {this.Altura}, Herramienta {this.TipoHerramienta}";
    }

    public Dron()
    {
        
    }

    public Dron(Herramienta pesoHerramienta)
    {
        double penalizacionVelocidad = 1 - pesoHerramienta.Peso /50 * 0.02;
        double penalizacionAltura = 1 - pesoHerramienta.Peso /50 * 0.05;

        this.Carga = pesoHerramienta.Peso - this.Carga;
        this.Velocidad = this.Velocidad * penalizacionVelocidad;
        this.Altura = this.Altura * penalizacionAltura;
        this.TipoHerramienta = pesoHerramienta;
    }
}