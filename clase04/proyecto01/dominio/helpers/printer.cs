namespace proyecto01.Dominio.Helpers;

public static class Printer
{
    public static void Print(string mensaje)
    {
        System.Console.WriteLine(mensaje);
    }
    public static void Print(Persona unaPersona)
    {
        System.Console.WriteLine(unaPersona.Saludar());
    }
}