using DesingPatterns.Structural.Decorator.Decorator.Interface;

namespace DesingPatterns.Structural.Decorator.Decorator
{
    public class Vehicle : IVehicle
    {
        public string? Model { get; set; }
        public string? Year { get; set; }
        public List<string> ListAccessory { get; set; } = new List<string>();



        public Vehicle GetVehicle()
        {
            var _vehicle = new Vehicle();
            _vehicle.Model = "DS 01";
            _vehicle.Year = "2024";
            _vehicle.ListAccessory.Add("Rodas de liga leve");

            return _vehicle;
        }
    }
}
