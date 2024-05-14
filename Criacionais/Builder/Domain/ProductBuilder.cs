namespace DesingPatterns.Criacionais.Builder.Builder
{
    public class ProductBuilder
    {
        private int productID;
        private string productCategory;
        private string subCategory;
        private string productName;
        private string productDescription;
        private decimal productPrice;
        private double productWeight;
        private int units;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductCategory
        {
            get { return productCategory; }
            set { productCategory = value; }
        }
        public string SubCategory
        {
            get { return subCategory; }
            set { subCategory = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }
        public decimal ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public double ProductWeight
        {
            get { return productWeight; }
            set { productWeight = value; }
        }
        public int Units
        {
            get { return units; }
            set { units = value; }
        }
        public decimal Total
        {
            get { return Units * ProductPrice; }
        }

    }
}