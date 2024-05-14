

namespace DesingPatterns.Behavior.State
{
    public class RequestCanceledState : IRentCarsState
    {
        public void CancelRequesRentCar()
        {
            Console.WriteLine("Your car rental request has already been canceled!");
        }

        public void ChooseColorAndModel()
        {
            Console.WriteLine("You cannot choose model and color, your rental request has been canceled !");
        }

        public void MakePayment()
        {
            Console.WriteLine("You cannot make payment, your rental request has been cancelled. !");
        }

        public void RequesRentCar()
        {
            Console.WriteLine("Your request was created successfully");
        }
    }
}
