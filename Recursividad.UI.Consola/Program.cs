using Rcurcividad.Logica;

Console.WriteLine("Metodos recurcivos");
Console.WriteLine("\n\n Calcular factorial de 5");

Recursividades oRecursividades = new Recursividades();
int resultado = oRecursividades.CalcularFactorial(5);

Console.WriteLine("el resultado es:" + resultado);