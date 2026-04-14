Articulo articulo = new Articulo();
articulo.Marca = "marolio";
articulo.Modelo = "fideos";

System.Console.WriteLine(articulo.Modelo + " " + articulo.Marca);

public class Articulo()
{
    private string _marca;
    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }
    
    private string _modelo;
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }

}