using DesingPatterns.Structural.Adapter.Interface;
using DesingPatterns.Structural.Adapter.Model;
using Newtonsoft.Json;

namespace DesingPatterns.Structural.Adapter
{
    public class ProductJSON : IProductJSON
    {
        //Adapteee
        public string GetProductJSONSpecifications()
        {

            List<Product> listProducts = new List<Product>();
            listProducts.Add(new Product 
            {
                Id = 01,
                Name= "Feijão",
                Description = "Alimento não perecível",
                Price = 7.50m,
                Qtd = 19
            });
            listProducts.Add(new Product
            {
                Id = 02,
                Name = "Arroz",
                Description = "Alimento não perecível",
                Price = 6.50m,
                Qtd = 135
            });
            listProducts.Add(new Product
            {
                Id = 03,
                Name = "Farinha",
                Description = "Alimento perecível",
                Price = 4.80m,
                Qtd = 34
            });
            listProducts.Add(new Product
            {
                Id = 04,
                Name = "Açucar",
                Description = "Alimento não perecível",
                Price = 6.50m,
                Qtd = 134
            });

            dynamic collectionProduct = new
            {
                products = listProducts
            };
            return JsonConvert.SerializeObject(collectionProduct);
        }
    }
}
