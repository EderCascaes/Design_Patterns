
using DesingPatterns.Structural.Facade.Intefaces;

namespace DesingPatterns.Structural.Facade
{
    public class Motorcycle : IMotorcycle
    {
        public void GetMotorcicleAbove500()
        {
            Console.WriteLine("Motorcycle Above 500cc.");
            GetAccessoriesMotorcycle();
            
        }

        public void GetMotorcicleUpTo450()
        {
            Console.WriteLine("Motorcycle up to 450.\n\n");
        }

        private void GetAccessoriesMotorcycle()
        {
            Console.WriteLine("\n Disc brake.");
            Console.WriteLine(" Eletric Ignition.");
        }

    }
}
