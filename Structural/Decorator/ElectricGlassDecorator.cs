using DesingPatterns.Structural.Decorator.Decorator;
using DesingPatterns.Structural.Decorator.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Structural.Decorator
{
    public class ElectricGlassDecorator : BaseVehicleDecorator
    {
        public ElectricGlassDecorator(IVehicle vehicle) 
            : base(vehicle){}


        public override Vehicle GetVehicle()
        {
            var vehicle = base.GetVehicle();

            if ("DS 01".Equals(vehicle.Model))
                vehicle.Model = "DX 01";

            else
                vehicle.Model = "DX 03";

            vehicle.ListAccessory.Add("Electric Glass");
            
            return vehicle;
        }
    }
}
