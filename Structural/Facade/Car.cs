
using DesingPatterns.Structural.Facade.Intefaces;

namespace DesingPatterns.Structural.Facade
{
    public class Car : ICar
    {
        public void GetLuxuryCar()
        {
            Console.WriteLine("Luxury Car : ");
            GetAccessoriesCar();
        }

        public void GetpopularCar()
        {
            Console.WriteLine("Popular Car.\n\n");
        }

        private void GetAccessoriesCar()
        {
            Console.WriteLine(" Hidraulic steering.");
            Console.WriteLine(" Air conditioner.");
        }


    }
}
