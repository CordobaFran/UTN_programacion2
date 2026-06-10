namespace ConsoleLibrary;

public class ComboPlatinumFactory : ITiendaOnline
{
    public IWebCam CrearProductoA()
    {
        return new WebCamPlatinum();
    }
    public IHeadset CrearProductoB()
    {
        return new HeadsetPlatinum();
        
    }
    public ITecladoMouse CrearProductoC()
    {
        return new TecladoMousePlatinum(); 
    }
}
