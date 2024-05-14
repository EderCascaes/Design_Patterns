using DesingPatterns.Criacionais.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Criacionais.Builder.Interfaces
{
    //abstraçao "Builder"
    public interface IConstructorClient
    {
        void ContructorClient(Client client, Address address, List<ProductBuilder> listProducts);
        void ConstructorAddress(Address address);
        void ConstructorListProducts(List<ProductBuilder> ListProduct);
        Client GetClient();
    }
}
