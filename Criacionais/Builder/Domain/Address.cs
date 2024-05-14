namespace DesingPatterns.Criacionais.Builder.Builder
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string Street, string City, string State, string ZipCode)
        {
            this.Street = Street;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
        }


    }
}