using System.Xml.Serialization;

namespace Patterns2.Adapter;

public class GeradorXml
{
  public string GeraXml(object obj)
  {
    var serializer = new XmlSerializer(obj.GetType());
    var writer = new StringWriter();
    serializer.Serialize(writer, obj);
    return writer.ToString();
  }
}