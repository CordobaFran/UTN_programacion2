using ConsoleLibrary;


    static void Main()
    {
        //creamos nodos
        CentroDistribucion tigre = new CentroDistribucion("tigre", "callefalsa123", camiones: 10, personal: 50, tiempo: 45.5f);
        PuntoRetiro sanIsidro = new PuntoRetiro("sanisidro", "hola123", personal: 3, tiempo: 15.0f);

        //creamos zona oepratica
        ZonasOperativas zonaNorte = new ZonasOperativas("Zn", "Rm");
        zonaNorte.AddNodo(tigre);
        zonaNorte.AddNodo(sanIsidro);

        //testinicial
        Console.WriteLine("--- test ---");
        Console.WriteLine($"direccion Zona: {zonaNorte.GetDireccion()}");
        Console.WriteLine($"total Camiones Zn: {zonaNorte.GetTotalCamiones()}");
        Console.WriteLine($"promedio tiempo entrega zn: {zonaNorte.TiempoMedioEntrega()} min");

        // 4. Modificamos valores en tiempo de ejecucion para probar dinamismo
        Console.WriteLine("\n--- cambio en ejecucion ---");
        tigre.SetCamiones(20); // Duplicamos camiones en Tigre
        sanIsidro.SetTiempoEntrega(25.0f); // Demora mas San Isidro

    }
