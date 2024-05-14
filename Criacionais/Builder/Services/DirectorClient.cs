using DesingPatterns.Criacionais.Builder.Builder;
using DesingPatterns.Criacionais.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Criacionais.Builder.Services
{
    public class DirectorClient
    {
        private IConstructorClient _constructorClient;

        public DirectorClient(IConstructorClient constructorClient)
        {
            _constructorClient = constructorClient;
        }

        public void ToBuildClient(Client client, Address address, List<ProductBuilder> listProducts)
        {
            _constructorClient.ConstructorAddress(address);
            _constructorClient.ConstructorListProducts(listProducts);
            _constructorClient.ContructorClient(client, address, listProducts);
        }
    }
}
