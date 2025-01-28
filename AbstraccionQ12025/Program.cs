
using AbstraccionQ12025;

const string CIRCULO = "Círculo";
const string RECTANGULO = "Rectángulo";

Circulo circulo = new Circulo();
Rectangulo rectangulo = new Rectangulo();

Console.WriteLine("Ingrese el radio:");
circulo.Radio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la base:");
rectangulo.Base = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la altura:");
rectangulo.Altura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Círculo:");
circulo.Imprimir(CIRCULO);

Console.WriteLine();
Console.WriteLine("Rectángulo:");
rectangulo.Imprimir(RECTANGULO);