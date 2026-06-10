namespace ConsoleLibrary;

public class ComboGoldFactory : ITiendaOnline
{
    public IWebCam CrearProductoA()
    {
        return new WebCamGold();
    }

    public IHeadset CrearProductoB()
    {
        return new HeadsetGold();
        
    }
    public ITecladoMouse CrearProductoC()
    {
        return new TecladoMouseGold();  
    }
}
