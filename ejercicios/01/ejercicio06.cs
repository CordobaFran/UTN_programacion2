Fruta unaFruta = new Fruta("verde", 200, true);

System.Console.WriteLine(unaFruta.EsComestible());

public class Fruta
{
    private string _color;
    public string Color     
    {
        get { return _color; }
        set { _color = value; }
    }
    private float _peso;
    public float Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }
    private bool _esEstacional;
    public bool EsEstacional
    {
        get { return _esEstacional; }
        set { _esEstacional = value; }
    }
    public Fruta(string color, float peso, bool esEstacional)
    {
        this.Color = color;
        this.Peso = peso;
        this.EsEstacional = esEstacional;
    }   
    public bool EsComestible()
    {
        if (this.Peso < 200 && this.EsEstacional == true)
        {
            return true;
        } else
        {
            return false;
        }
    }
    
}