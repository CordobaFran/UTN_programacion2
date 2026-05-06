namespace clases.VagonPasajeros;
using clases.Vagones;

public class VagonPasajeros : Vagones
{
    private int _cantPasajeros;
    public int CantPasajeros
    {
        get { return _cantPasajeros; }
        set { _cantPasajeros = value; }
    }
    
    public float CalcularCargaMax()
    {
        return _cantPasajeros * 80;
    }

    public int CalcularPasajeros()
    {
        if (this.Ancho <= 2.5) return this.Largo * 8;
        return this.Largo * 10;
    }

    public VagonPasajeros(int largo, int ancho) : base(largo, ancho)
    {
        _cantPasajeros = CalcularPasajeros();
        CargaMaxima = CalcularCargaMax();
    }
}