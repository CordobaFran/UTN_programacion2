Cine pelicula01 = new Cine("Hulk", "20:00");
pelicula01.obtenerCartelera();

Cine pelicula02 = new Cine("Avatar", "17:00");
pelicula02.obtenerCartelera();

pelicula01.Pelicula = "Interstelar";
// Cine pelicula01 = new Cine("Intersterlar", "16:00");
pelicula01.obtenerCartelera();



public class Cine
{
    private string? _pelicula;   
    public string? Pelicula
    {
        get { return _pelicula; }
        set { _pelicula = value; }
    }

    private string? _horario;
    public string? Horario
    {
        get { return _horario; }
        set { _horario = value; }
    }

    public Cine(){}
    public Cine(string pelicula, string horario)
    {
        this.Pelicula = pelicula;
        this.Horario = horario;
    }

    public void obtenerCartelera()
    {
        System.Console.WriteLine($"La pelicula {this.Pelicula} comienza a las {this.Horario} hs");
    }

}