using proyecto01.Dominio;
using proyecto01.Dominio.Helpers;

Console.WriteLine("Hello, World!");

Alumno unaPersona = new Alumno("1234", 9);
unaPersona.SetNombre("Franco");
unaPersona.SetApellido("Cordoba");
unaPersona.SetEmail("francocordobafs@gmail.com");
//unaPersona.Legajo = "1234";

Docente unDocente = new Docente();
unDocente.SetNombre("Fran");
unDocente.SetApellido("Cor");
unDocente.Materia= "matematica";
unDocente.Legajo = "123434";

Alumno unaPersona2 = new Alumno("Franco","Damian", "frankitoxvc@gmail.com", "1235", 8);



System.Console.WriteLine(unaPersona.Saludar());
Printer.Print(unDocente);
Printer.Print(unaPersona2.Saludar());
  