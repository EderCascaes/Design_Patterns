

namespace DesingPatterns.Behavior.State
{
    public interface IRentCarsState
    {
        void RequesRentCar();
        void CancelRequesRentCar();
        void ChooseColorAndModel();
        void MakePayment();

    }
}
