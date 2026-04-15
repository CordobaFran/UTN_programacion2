using Dominio.Dron;
using Dominio.Herramienta;

Herramienta infrarrojo = new SensorInfrarrojo();
Taser taser = new Taser();
BrazoRobotico brazoRobotico = new BrazoRobotico();
Dron unDron = new Dron(brazoRobotico);
Dron dosDron = new Dron(taser);
Dron tresDron = new Dron(infrarrojo);

System.Console.WriteLine(unDron.PrintDron());
System.Console.WriteLine(dosDron.PrintDron());
System.Console.WriteLine(tresDron.PrintDron());