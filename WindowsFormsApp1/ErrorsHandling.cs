using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class ErrorsHandling
    {
        static readonly string filename = "errorlog";
        static bool isHeaderAlreadyAdded = false;
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
                        if(!isHeaderAlreadyAdded)
                        {
                            file.WriteLine($"Error,{Environment.NewLine}{message},");
                            isHeaderAlreadyAdded = true;
                        }else
                        {
                            file.WriteLine(SaveAsCsv(message));
                        }                        
                        break;
                    case (ErrorsHandling.FilesExtenstions.XML):
                        file.WriteLine(SaveAsXml(message));
                        break;
                    case (ErrorsHandling.FilesExtenstions.TSV):
                        file.WriteLine(SaveAsTsv(message));
                        break;
                }
            }
        }
        private static string SaveAsCsv(string message)
        {
            return $"{message},";
        }
        private static string SaveAsTsv(string message)
        {
            return $"Error\t{Environment.NewLine}{message}\t";
        }
        private static string SaveAsXml(string message)
        {
            return $"<value>{Environment.NewLine}\t<error>{message}</error>{Environment.NewLine}</value>";
        }
    }
}