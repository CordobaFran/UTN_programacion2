namespace ConsoleLibrary;

public class ComboStarterFactory : ITiendaOnline
{
    public IWebCam CrearProductoA()
    {
        return new WebCamStarter();
    }
    public IHeadset CrearProductoB()
    {
        return new HeadsetStarter();
    }
    public ITecladoMouse CrearProductoC()
    {
        return new TecladoMouseStarter();        
    }
}
