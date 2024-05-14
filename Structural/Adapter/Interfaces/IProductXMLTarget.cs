using System.Xml;

namespace DesingPatterns.Structural.Adapter.Interface
{
    public interface IProductXMLTarget
    {
        XmlDocument GetProductXMLSpecification();
    }
}
