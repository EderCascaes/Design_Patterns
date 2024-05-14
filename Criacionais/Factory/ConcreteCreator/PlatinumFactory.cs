using DesingPatterns.Criacionais.Factory.ConcreteProduct;
using DesingPatterns.Criacionais.Factory.Creator;
using DesingPatterns.Criacionais.Factory.ProductFactory;


namespace DesingPatterns.Criacionais.Factory.ConcreteCreator
{
    public class PlatinumFactory : CardFactory
    {
        private int _limitCredit;
        private int _annualBilling;

        public PlatinumFactory(int limitCredit, int annualBilling)
        {
            this._limitCredit = limitCredit;
            this._annualBilling = annualBilling;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCard(_limitCredit, _annualBilling);
        }
    }
}
