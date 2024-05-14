using DesingPatterns.Structural.Adapter.Interface;
using Newtonsoft.Json;
using System.Xml;

namespace DesingPatterns.Structural.Adapter
{
    public class PruductXMLAdapter : IProductXMLTarget
    {
        public XmlDocument GetProductXMLSpecification()
        {
            ProductJSON productJSONAdaptee = new ProductJSON();
            
            var result =  JsonConvert.DeserializeXmlNode(
                            productJSONAdaptee.GetProductJSONSpecifications(),
                            "Super Ed",
                            true
                            );

            return result;
        }
    }
}
