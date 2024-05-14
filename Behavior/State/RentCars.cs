

namespace DesingPatterns.Behavior.State
{
    public class RentCars : IRentCarsState
    {
        public IRentCarsState rendCarsState { get; set; }

        public RentCars()
        {
            rendCarsState = new RequesMadeState();
        }

        public void RequesRentCar()
        {
            Console.WriteLine("Rental application in progress!");

            string? response = null;

            while (response == null || (response.ToUpper() != "Y" && response.ToUpper() != "N"!))
            {
                Console.WriteLine("Do you want to choose color and model");
                Console.Write("\n(Y) Yes \n(N) No - Cancel Request\n ");
                response = Console.ReadLine();               
            }
            if(response.ToUpper() == "N")
            {
                rendCarsState.CancelRequesRentCar();
                //choose state for cancel
                rendCarsState = new RequestCanceledState();                
            }
        }

        public void CancelRequesRentCar()
           => rendCarsState.CancelRequesRentCar();
        

        public void ChooseColorAndModel()
        {
            if (rendCarsState is RequesMadeState)
                rendCarsState.ChooseColorAndModel();
            
            else            
                Console.WriteLine(
                    "You cannot choose the color and model, " +
                    "this rental request is cancelled.");
            
        }

        public void MakePayment()
        {
            if(rendCarsState is RequesMadeState)            
                rendCarsState.MakePayment();
            
            else            
                Console.WriteLine(
                    "You cannot make payment, " +
                    "this rental request is cancelled.");
            

        }
    }
}
