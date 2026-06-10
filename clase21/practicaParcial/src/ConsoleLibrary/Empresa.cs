namespace ConsoleLibrary;

public class Empresa
{
    private List<Documentos> _documentos;
    public List<Documentos> Documentos
    {
        get { return _documentos; }
        set { _documentos = value; }
    }

    private Iprocesador _strategy;
    public Iprocesador Strategy
    {
        get { return _strategy; }
        set { _strategy = value; }
    }

    public void ProcesarDocumento(Documento doc)
    {
        _strategy.Procesar(doc);
    }

    public void SetStrategy(Iprocesador strategy)
    {
        Strategy = strategy;
    }

}