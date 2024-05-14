using DesingPatterns.Structural.Decorator.Decorator;
using DesingPatterns.Structural.Decorator.Decorator.Interface;

namespace DesingPatterns.Structural.Decorator
{
    public class BaseVehicleDecorator : IVehicle
    {
        private readonly IVehicle _vehicle;
        public BaseVehicleDecorator(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public virtual Vehicle GetVehicle() 
                   => _vehicle.GetVehicle();      
    
    }
}
