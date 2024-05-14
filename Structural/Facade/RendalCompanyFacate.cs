
using DesingPatterns.Structural.Facade.Intefaces;

namespace DesingPatterns.Structural.Facade
{
    public class RendalCompanyFacate
    {
        private readonly ICar _rendalCompanyCar;
        private readonly IMotorcycle _rendalCompanyMotorcycle;

        public RendalCompanyFacate()
        {
            _rendalCompanyCar = new Car();
            _rendalCompanyMotorcycle = new Motorcycle();
        }


        public void GetLuxuryCar()
        {
            _rendalCompanyCar.GetLuxuryCar();
        }

        public void GetpopularCar()
        {
            _rendalCompanyCar.GetpopularCar();
        }

        public void GetMotorcicleAbove500()
        {
            _rendalCompanyMotorcycle.GetMotorcicleAbove500();
        }

        public void GetMotorcicleUpTo450()
        {
            _rendalCompanyMotorcycle.GetMotorcicleUpTo450();
        }



    }
}
