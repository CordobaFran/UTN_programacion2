// Persona unaPersona = new Persona();
// unaPersona.Nombre = "Franco";
// unaPersona.Apellido = "Cordoba";
// System.Console.WriteLine(unaPersona.Saludar());

// invocar a un constructor siempre nos devuelve un objeto nuevo

Alumno unAlumno = new Alumno();
unAlumno.Nombre = "Franco";
unAlumno.Apellido = "Cordoba";
unAlumno.NumeroDeMatricula = 1234;

Profesor unProfesor = new Profesor();
unProfesor.Nombre = "Simona";
unProfesor.Apellido = "Gato";
unProfesor.Legajo = 4567;

System.Console.WriteLine(unAlumno.Saludar());

Examen examen = new Examen(unAlumno, unProfesor, DateTime.Now);

System.Console.WriteLine(examen.Alumno.Nombre);

public abstract class Persona
{
    private string nombre;
    private string apellido;

    public virtual string Saludar()
    {
        return "Hola me llamo " + nombre + " " + apellido + ".";
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }
    
    
}

public class Profesor : Persona
{
    private int legajo;
    public int Legajo
    {
        get { return legajo; }
        set { legajo = value; }
    }

    public override string Saludar()
    {
        return "Hola soy el alumno " + Nombre + Apellido + "y mi legajo es " + Legajo;
    }
    
}

public class Alumno : Persona
{
    private int numeroDeMatricula;
    public int NumeroDeMatricula
    {
        get { return numeroDeMatricula; }
        set { numeroDeMatricula = value; }
    }

    public override string Saludar()
    {
        return "Hola soy el alumno " + Nombre + " " + Apellido + "y mi Matricula es " + NumeroDeMatricula;
    }
    
}

public class Examen
{
    public Examen(Alumno alumno, Profesor profesor, DateTime fecha)
    {
        Alumno = alumno;
        Profesor = profesor;
        this._fecha = fecha;
         
    }
    private float _nota;
    public float Nota
    {
        get { return _nota; }
        set { _nota = value; }
    }
    
    private Alumno _alumno;
    public Alumno Alumno
    {
        get { return _alumno; }
        set { _alumno = value; }
    }
    
    private DateTime _fecha;
    public DateTime Fecha
    {
        get { return _fecha; }
        set { _fecha = value; }
    }
    
    private Profesor _profesor;
    public Profesor Profesor
    {
        get { return _profesor; }
        set { _profesor = value; }
    }
    
}