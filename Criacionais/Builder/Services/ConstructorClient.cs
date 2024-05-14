using DesingPatterns.Criacionais.Builder.Builder;
using DesingPatterns.Criacionais.Builder.Interfaces;

namespace DesingPatterns.Criacionais.Builder.Services
{
    public class ConstructorClient : IConstructorClient
    {
        private Client _client = new Client();
        public void ConstructorAddress(Address address)
            => new Address(
                address.Street,
                address.City,
                address.State,
                address.ZipCode
                );



        public void ConstructorListProducts(List<ProductBuilder> listProduct)
        {
            var newListProiducts = new List<ProductBuilder>();

            foreach (var item in listProduct)
            {
                newListProiducts.Add(item);
            }
        }

        public void ContructorClient(Client client, Address address, List<ProductBuilder> listProducts)
            => new Client(
                _client.Id = client.Id,
                _client.Name = client.Name,
                _client.Description = client.Description,
                _client.Address = address,
                _client.listProducts = listProducts
                );


        public Client GetClient() => _client;

    }
}
