namespace ConsoleLibrary;

public class ProcesoEncriptacion
{
    public void Procesar(Documento documento)
    {
        string oldName = documento.Nombre;
	    documento.Nombre = "encripted_" + oldName;
    }
}
