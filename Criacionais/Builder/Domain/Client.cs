namespace DesingPatterns.Criacionais.Builder.Builder
{
    public class Client
    {
        public Client() { }
        public Client(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;

        }

        public Client(int id, string name, string description, Address address, List<ProductBuilder> listProducts)
        {
            Id = id;
            Name = name;
            Description = description;
            Address = address;
            this.listProducts = listProducts;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public List<ProductBuilder> listProducts { get; set; }
    }
}
