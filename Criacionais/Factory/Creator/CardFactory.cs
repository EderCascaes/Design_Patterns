using DesingPatterns.Criacionais.Factory.ProductFactory;

namespace DesingPatterns.Criacionais.Factory.Creator
{
    public abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
