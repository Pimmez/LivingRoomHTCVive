using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("LanguagesCollection")]
public class ItemContaining
{
    [XmlArray("Languages"), XmlArrayItem("Lang")]
    public List<Languages> languagess = new List<Languages>();

    public static ItemContaining Load(string path)
    {
        var serializer = new XmlSerializer(typeof(ItemContaining));

        var reader = new FileStream(path, FileMode.Open);

        var deserialized = serializer.Deserialize(reader) as ItemContaining;

        reader.Close();

        return deserialized;

    }
}
