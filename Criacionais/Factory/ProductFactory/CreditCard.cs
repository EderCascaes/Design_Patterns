namespace DesingPatterns.Criacionais.Factory.ProductFactory
{
    public abstract class CreditCard
    {
        public abstract string TypeCard { get; }
        public abstract int LimitCredit { get; set; }
        public abstract int AnnualBilling { get; set; }  // cobrança anual
    }
}
