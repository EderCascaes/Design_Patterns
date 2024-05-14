using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Behavior.State
{
    public class RequesMadeState : IRentCarsState
    {
        public void CancelRequesRentCar()
        {
            Console.WriteLine("Car rental requisition successfully canceled!");
        }

        public void ChooseColorAndModel()
        {
            Console.WriteLine("Choose model and color of your car!");
        }

        public void MakePayment()
        {
            Console.WriteLine("Make your rental payment!");
        }

        public void RequesRentCar()
        {
            Console.WriteLine("Operation Invalid, there is already a request in progress");
        }

    }
}
