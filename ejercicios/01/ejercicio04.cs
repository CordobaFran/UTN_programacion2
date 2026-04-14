Cine unaPelicula = new Cine();
unaPelicula.Pelicula = "Avatar";
unaPelicula.Horario = "20hs";

System.Console.WriteLine(unaPelicula.obtenerCartelera());

public class Cine
{
    private string _pelicula;
    public string Pelicula
    {
        get { return _pelicula; }
        set { _pelicula = value; }
    }

    private string _horario;
    public string Horario
    {
        get { return _horario; }
        set { _horario = value; }
    }

    public string obtenerCartelera()
    {
        return "La pelicula: " + this.Pelicula + " es a las : " + this.Horario;
    }
    
}