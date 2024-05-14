using DesingPatterns.Criacionais.Factory.ProductFactory;

namespace DesingPatterns.Criacionais.Factory.ConcreteProduct
{
    public class PlatinumCard : CreditCard
    {
        private readonly string _typeCard;
        private int _limitCredit;
        private int _annualBilling;

        public PlatinumCard(int _limitCredit, int _annualBilling)
        {
            _typeCard = "Platinum";
            this._limitCredit = _limitCredit;
            this._annualBilling = _annualBilling;
        }

        public override string TypeCard
        {
            get { return _typeCard; }
        }
        public override int LimitCredit
        {
            get { return _limitCredit; }
            set { _limitCredit = value; }
        }

        public override int AnnualBilling
        {
            get { return _annualBilling; }
            set { _annualBilling = value; }
        }

    }
}
