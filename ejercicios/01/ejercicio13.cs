Traccion caucho = new Caucho();
Traccion oruga = new Oruga();
Robot robotina = new Robot(oruga);

System.Console.WriteLine(robotina.PrintRobot());



public class Robot
{
    private string numeroSerie = "KT-2020-P";
    public string NumeroSerie
    {
        get { return numeroSerie; }
        set { numeroSerie = value; }
    }

    private int potenciaTraccion = 10;
    public int PotenciaTraccion
    {
        get { return potenciaTraccion; }
        set { potenciaTraccion = value; }
    }

    private Traccion traccion;
    public Traccion Traccion
    {
        get { return traccion; }
        set { traccion = value; }
    }

    public Robot()
    {
        
    }
    public Robot(Traccion tipoTraccion)
    {
        this.PotenciaTraccion -= tipoTraccion.CosteTraccion;
        this.Traccion = tipoTraccion;
    }
    public string PrintRobot()
    {
        return $"N° de serie: {this.NumeroSerie} Potencia: {this.PotenciaTraccion} Tipo de Traccion: {this.Traccion} Autonomia: {this.Traccion.Autonomia}";
    }

}

public class Traccion
{
    private int autonomia;
    public int Autonomia
    {
        get { return autonomia; }
        set { autonomia = value; }
    }

    private int costeTraccion;
    public int CosteTraccion
    {
        get { return costeTraccion; }
        set { costeTraccion = value; }
    }

}

public class Oruga : Traccion
{
    private string sensor = "Meke-M0";
    public string Sensor
    {
        get { return sensor; }
        set { sensor = value; }
    }

    public Oruga()
    {
        this.Autonomia = 300;
        this.CosteTraccion = 3;
    }
}

public class Caucho : Traccion
{
    public Caucho()
    {
        this.Autonomia = 100;
        this.CosteTraccion = 1;
    }
}