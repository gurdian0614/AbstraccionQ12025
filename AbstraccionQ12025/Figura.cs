
namespace AbstraccionQ12025
{
    public abstract class Figura
    {
        /// <summary>
        /// Abstract method that calculates the geometric area
        /// </summary>
        /// <returns>Area value</returns>
        public abstract double Area();

        /// <summary>
        /// Abstract method that calculatrs the perimeter
        /// </summary>
        /// <returns>Perimeter Value</returns>
        public abstract double Perimetro();

        /// <summary>
        /// Print the area and perimeter values
        /// </summary>
        /// <param name="NombreFigura">Geometric name</param>
        public void Imprimir(string NombreFigura)
        {
            Console.WriteLine($"Area del {NombreFigura}: {Area()} cm2");
            Console.WriteLine($"Perímetro del {NombreFigura}: {Perimetro()} cm");
        }
    }
}
