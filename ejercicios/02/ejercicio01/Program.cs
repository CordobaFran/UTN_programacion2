using dominio.Figura;

Figura circulo = new Circulo(5);
Figura cuadrado = new Cuadrado(10);
Figura triangulo = new Triangulo(7,5,4);

System.Console.WriteLine(circulo.Perimetro);
System.Console.WriteLine(cuadrado.Area);
System.Console.WriteLine(triangulo.Area);
