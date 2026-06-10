using System.ComponentModel.DataAnnotations;
using ConsoleLibrary;


MyList<string> myList = new MyList<string>();
myList.Push("Andrés");
//myList.Push(2);
myList.Push("Carlos");

myList.InsertUnique("Mario");
myList.Print();
Console.WriteLine("Después de intentar insertar el valor Mario:  ");


var busqueda = myList.Search("Mario");
Console.WriteLine("El buscado fue: " +  busqueda.Value);

myList.InsertUnique("Leonardo");

myList.Print();
