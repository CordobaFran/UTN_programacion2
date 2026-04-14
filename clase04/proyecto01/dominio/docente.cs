namespace proyecto01.Dominio;

public class Docente : Persona
{
    public string Materia { get; set; }
    public string Legajo { get; set; }
    
    public override string Saludar()
    {
        return $"{base.Saludar()}, mi legajo es {Legajo}, mi materia es: {Materia}"; // base es como el this, pero lo usamos para llamar al metodo saludar del padre, Persona"
    }

    //lo abstracto no puede tener comportamiento
}