using DesingPatterns.Structural.Decorator.Decorator;
using DesingPatterns.Structural.Decorator.Decorator.Interface;

namespace DesingPatterns.Structural.Decorator
{
    public class AutomaticTransmissionDecorator : BaseVehicleDecorator
    {
        public AutomaticTransmissionDecorator(IVehicle vehicle)
            : base(vehicle){ }

        public override Vehicle GetVehicle()
        {
            var vehicle = base.GetVehicle();

            if ("DS 01".Equals(vehicle.Model))
                vehicle.Model = "DD 01";

            else
                vehicle.Model = "DX 03";            
            
            vehicle.ListAccessory.Add("Automatic Transmission");
            return vehicle;
        }
    }
}
