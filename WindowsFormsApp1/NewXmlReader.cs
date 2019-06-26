using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    static class NewXmlReader
    {
        public static List<Tuple<double,double>> GetNodes(string xmlPath)
        {
            List<Tuple<double, double>> result = new List<Tuple<double, double>>();
            string strA;
            string strB;
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlPath);
            foreach (XmlNode node in xml.DocumentElement)
            {
                if (!node.HasChildNodes)
                {
                    strA = node.Attributes[0].Value;
                    try
                    {
                        strB = node.Attributes[1].Value;
                    }
                    catch
                    {
                        strB = null;
                    }
                }
                else
                {
                    strA = node.ChildNodes.Item(0).InnerText;
                    try
                    {
                        strB = node.ChildNodes.Item(1).InnerText;
                    }
                    catch
                    {
                        strB = null;
                    }
                }
                Double.TryParse(strA, out double doubleA);
                Double.TryParse(strB, out double doubleB);
                result.Add(Tuple.Create(doubleA, doubleB));
            }
            return result;
        }
    }
}