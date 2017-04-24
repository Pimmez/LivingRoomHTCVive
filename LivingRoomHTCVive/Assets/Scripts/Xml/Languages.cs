using UnityEngine;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Languages
{ 

    [XmlElement("TouchPadL")]
    public string touchPadL;

    [XmlElement("Changelanguage")]
    public string changeLanguage;

    [XmlElement("TriggerButtonL")]
    public string triggerButtonL;

    [XmlElement("GripButtonL")]
    public string gripButtonL;

    [XmlElement("TriggerButtonR")]
    public string triggerButtonR;

    [XmlElement("GripButtonR")]
    public string gripButtonR;

    [XmlElement("CurrentLanguage")]
    public string currentLanguage;

    [XmlElement("LightSwitch")]
    public string lightSwitch;

    [XmlElement("WallRendererSwitch")]
    public string wallRendererSwitch;


}
