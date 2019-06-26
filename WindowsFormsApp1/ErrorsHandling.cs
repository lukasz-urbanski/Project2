using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    static class ErrorsHandling
    {
        static readonly string filename = "errorlog";
        static bool isCsvAlreadyAdded = false;
        static bool isTsvAlreadyAdded = false;
        static bool isXmlAlreadyAdded = false;
        public enum FilesExtenstions
        {
            TXT,
            CSV,
            TSV,
            XML
        }
        static public void ShowMessageAndSaveLogWithErrors(string message, string filepath, ErrorsHandling.FilesExtenstions ext)
        {
            string fileWithExt = $"{filename}.{ext}";
            MessageBox.Show(message);

            using (StreamWriter file = new StreamWriter(Path.Combine(filepath, fileWithExt), true))
            {
                string test = Path.Combine(filepath, fileWithExt);
                switch (ext)
                {
                    case (ErrorsHandling.FilesExtenstions.TXT):
                        file.WriteLine(message);
                        break;
                    case (ErrorsHandling.FilesExtenstions.CSV):
                        if (!isCsvAlreadyAdded)
                        {
                            file.WriteLine($"Error,{Environment.NewLine}{message},");
                            isCsvAlreadyAdded = true;
                        }
                        else
                        {
                            file.WriteLine(SaveAsAnyStringSepatedValue(message, ","));
                        }
                        break;
                    case (ErrorsHandling.FilesExtenstions.TSV):
                        if (!isTsvAlreadyAdded)
                        {
                            file.WriteLine($"Error\t{Environment.NewLine}{message}\t");
                            isTsvAlreadyAdded = true;
                        }
                        else
                        {
                            file.WriteLine(SaveAsAnyStringSepatedValue(message, "\t"));
                        }
                        break;
                    case (ErrorsHandling.FilesExtenstions.XML):
                        file.Close();
                        if (!isXmlAlreadyAdded)
                        {
                            CreateXml(message, fileWithExt);
                            isXmlAlreadyAdded = true;
                        }
                        else
                        {
                            EditXml(message, fileWithExt);
                        }
                        break;
                }
            }
        }
        private static string SaveAsAnyStringSepatedValue(string message, string separator)
        {
            return $"{message}{separator}";
        }
        private static void CreateXml(string message, string xmlFileName)
        {
            // return $"<value>{Environment.NewLine}\t<error>{message}</error>{Environment.NewLine}</value>";
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("errors");
            xmlDoc.AppendChild(rootNode);

            XmlNode errorNode = xmlDoc.CreateElement("error");
            errorNode.InnerText = message;
            rootNode.AppendChild(errorNode);

            xmlDoc.Save(xmlFileName);
        }

        public static void EditXml(string message, string fullpath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fullpath);

            XmlElement el = (XmlElement)doc.SelectSingleNode("errors");

            if (el != null)
            {
                XmlElement elem = doc.CreateElement("error");
                elem.InnerText = message;
                el.AppendChild(elem);
            }
            doc.Save(fullpath);
        }
    }
}