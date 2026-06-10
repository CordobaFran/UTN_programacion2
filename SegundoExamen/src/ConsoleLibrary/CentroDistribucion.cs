namespace ConsoleLibrary;

public class CentroDistribucion : NodoLogistico
{
    private int _cantCamiones;
    private int _cantPersonal;
    private float _tiempoMedioEntrega;

    public CentroDistribucion(string nombre, string direccion, int camiones, int personal, float tiempo) : base(nombre, direccion)
    {
        _cantCamiones = camiones;
        _cantPersonal = personal;
        _tiempoMedioEntrega = tiempo;
    }

    public void SetCamiones(int camiones)
    {
        _cantCamiones = camiones;
    }
    public void SetTiempoEntrega(float tiempo)
    {
        _tiempoMedioEntrega = tiempo;
    }

    public override int GetTotalCamiones()
    {
       return _cantCamiones;
    }
    public override float TiempoMedioEntrega()
    {
       return _tiempoMedioEntrega;
    }
}