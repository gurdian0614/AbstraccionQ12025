
namespace AbstraccionQ12025
{
    public class Circulo : Figura
    {
        public double Radio;

        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
