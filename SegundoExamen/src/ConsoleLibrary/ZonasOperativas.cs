namespace ConsoleLibrary;
public class ZonasOperativas : NodoLogistico
{
    private List<NodoLogistico> _conjuntoNodos = new List<NodoLogistico>();

    public ZonasOperativas(string nombre, string direccion) : base(nombre, direccion) { }

    public void AddNodo(NodoLogistico nodo)
    {
        _conjuntoNodos.Add(nodo);
    }
    public void RemoveNodo(NodoLogistico nodo)
    {
        _conjuntoNodos.Remove(nodo);
    }

    public override int GetTotalCamiones()
    {
        return _conjuntoNodos.Sum(nodo => nodo.GetTotalCamiones());
    }

    public override float TiempoMedioEntrega()
    {
        if (_conjuntoNodos.Count == 0) return 0f;
        return _conjuntoNodos.Average(nodo => nodo.TiempoMedioEntrega());
    }
}