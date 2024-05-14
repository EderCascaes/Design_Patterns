using DesingPatterns.Criacionais.Factory.ConcreteProduct;
using DesingPatterns.Criacionais.Factory.Creator;
using DesingPatterns.Criacionais.Factory.ProductFactory;


namespace DesingPatterns.Criacionais.Factory.ConcreteCreator
{
    public class TitaniumFactory : CardFactory
    {
        private int _limitCredit;
        private int _annualBilling;

        public TitaniumFactory(int limitCredit, int annualBilling)
        {
            this._limitCredit = limitCredit;
            this._annualBilling = annualBilling;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCard(_limitCredit, _annualBilling);
        }

    }
}
