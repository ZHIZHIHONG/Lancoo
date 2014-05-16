using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CeShi
{
    public class Company
    {
        [XmlAttribute] public string CompanyName;

        [XmlAnyAttribute] public XmlAttribute[] XAttributes;

        [XmlAnyElement] public XmlElement[] XElements;

        [XmlElement(ElementName = "Members")] public Employee[] Employees;

        public static void Text()
        {
                       

        }
    }
}
