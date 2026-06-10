namespace ConsoleLibrary;
public class PuntoRetiro : NodoLogistico
{
    private int _personalAtencion;
    private float _tiempoMedioEntrega;

    public PuntoRetiro(string nombre, string direccion, int personal, float tiempo) 
        : base(nombre, direccion)
    {
        _personalAtencion = personal;
        _tiempoMedioEntrega = tiempo;
    }

    public void SetTiempoEntrega(float tiempo)
    {
        _tiempoMedioEntrega = tiempo;
    }

    public override int GetTotalCamiones()
    {
        return 0;     
    }
    public override float TiempoMedioEntrega() => _tiempoMedioEntrega;
}