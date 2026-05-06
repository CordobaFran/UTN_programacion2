namespace clases.Formacion;
using clases.Locomotora;
using clases.Vagones;

public class Formacion
{
    private List<Locomotora>? _locomotoras = new List<Locomotora>();
    public List<Locomotora>? Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }
    private List<Vagones>? _vagones = new List<Vagones>();
    public List<Vagones>? Vagones
    {
        get { return _vagones; }
        set { _vagones = value; }
    }
    private bool _enMovimiento = false;
    public bool EnMovimiento
    {
        get { return _enMovimiento; }
        set { _enMovimiento = value; }
    }
    

    public void AgregarLocomotora(Locomotora locomotora)
    {
        if (! _enMovimiento)
        {
            _locomotoras?.Add(locomotora);
        }
    }
}