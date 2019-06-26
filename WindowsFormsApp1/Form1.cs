using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.filesExtComboBox.DataSource = Enum.GetValues(typeof(ErrorsHandling.FilesExtenstions));
            this.filesExtComboBox.SelectedIndex = 0;
        }

        int numberofoperations = 1;

        string operationtype = "multiplication";

        double a;
        double b;
        string operationtype_string = "*";
        List<Tuple<double, double>> pairs = new List<Tuple<double, double>>();

        public double Calculate(double a, double b, string operationtype)
        {
            double b1;
            switch (operationtype)
            {
                case "multiplication":
                    b1 = a * b;
                    break;

                case "division":
                    b1 = Divide(a, b);
                    break;

                case "exponentiation":
                    b1 = Math.Pow(a, b);
                    break;

                case "subtraction":
                    b1 = a - b;
                    break;

                case "adding":
                    b1 = a + b;
                    break;

                case "modulo":
                    b1 = a % b;
                    break;

                default:
                    throw new InvalidCastException();
            }
            return b1;
        }

        private double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            return a / b;
        }

        private void Replicator(int numberofoperations)
        {
            double current_b;

            for (int j = 0; j < numberofoperations; j++)
            {
                current_b = b;
                try
                {
                    b = Calculate(a, b, operationtype);
                    CombineAndSaveLog(j + 1, numberofoperations, operationtype_string, a, current_b, b.ToString());

                }
                catch (DivideByZeroException)
                {
                    CombineAndSaveLog(j + 1, numberofoperations, operationtype_string, a, current_b, " Divide by zero");
                }
                catch (InvalidCastException)
                {
                    CombineAndSaveLog(j + 1, numberofoperations, operationtype_string, a, current_b, " Incorrect calculation type");
                }
                catch (Exception)
                {
                    SaveLog("i can't imagine what must happen to show this");
                }
                //you are only catching specific types of errors. What if a Null reference error happens?
                // WM:does this solve your comment?
            }
        }
        private void StartBT_Click(object sender, EventArgs e)
        {
            string filepath = ErrorLogFilePathValidation.IsValid(this.errorLogPathTextBox.Text);

            ErrorsHandling.FilesExtenstions extenstionSelected =
                    (ErrorsHandling.FilesExtenstions)Enum.Parse(typeof(ErrorsHandling.FilesExtenstions), filesExtComboBox.Text);
            pairs.Clear();
            if (File.Exists(PathTB.Text))
            {
                ReadXML(PathTB.Text);
                if (Int32.TryParse(OperationCountTB.Text, out numberofoperations))
                {
                    if (pairs.Count > 0)
                    {
                        foreach (var pair in pairs)
                        {
                            a = pair.Item1;
                            b = pair.Item2;
                            Replicator(numberofoperations);
                        }
                    }
                    else
                    {
                        ErrorsHandling.ShowMessageAndSaveLogWithErrors("XML doesn;t contain any valid pairs of 'a' and 'b' attributes", filepath, extenstionSelected);
                    }
                }
                else
                {
                    ErrorsHandling.ShowMessageAndSaveLogWithErrors(String.Format("This: {0} is not an integer", OperationCountTB.Text), filepath, extenstionSelected);
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(PathTB.Text))
                {
                    ErrorsHandling.ShowMessageAndSaveLogWithErrors($"File under path {PathTB.Text} doesn't exist.", filepath, extenstionSelected);
                }
                else
                {
                    ErrorsHandling.ShowMessageAndSaveLogWithErrors($"Path to file wasn't selected.", filepath, extenstionSelected);
                }
            }
        }
        private void ReadXML(string path)
        {
            string logline = "\r\nValues in XML: \r\n";
            int count = 0;

            try
            {
                pairs = NewXmlReader.GetNodes(path);
                foreach (Tuple<double, double> tuple in pairs)
                {
                    logline += String.Format("{0}: a={1}, b={2}\r\n", count, tuple.Item1.ToString(), tuple.Item2.ToString());
                }
            }
            catch (XmlException e)
            {
                MessageBox.Show(e.Message.ToString());
                string filepath = ErrorLogFilePathValidation.IsValid(this.errorLogPathTextBox.Text);
                ErrorsHandling.FilesExtenstions extenstionSelected =
                        (ErrorsHandling.FilesExtenstions)Enum.Parse(typeof(ErrorsHandling.FilesExtenstions), filesExtComboBox.Text);
                ErrorsHandling.ShowMessageAndSaveLogWithErrors(e.Message.ToString(), filepath, extenstionSelected);
            }
            #region Previous XML Reader
            /*
            using (XmlTextReader reader = new XmlTextReader(path))
            {
                try
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                if (reader.Name == "value")
                                {
                                    if (Double.TryParse(reader.GetAttribute("first"), out valA) && Double.TryParse(reader.GetAttribute("second"), out valB))
                                    {
                                        count++;
                                        
                                        pairs.Add(Tuple.Create(valA, valB));
                                        logline += String.Format("{0}: a={1}, b={2}\r\n", count, valA.ToString(), valB.ToString());
                                        
                                    }
                                    else
                                    {

                                    }
                                }
                                break;
                        }
                    }
                }
                catch (XmlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                    string filepath = ErrorLogFilePathValidation.IsValid(this.errorLogPathTextBox.Text);
                    ErrorsHandling.FilesExtenstions extenstionSelected =
                            (ErrorsHandling.FilesExtenstions)Enum.Parse(typeof(ErrorsHandling.FilesExtenstions), filesExtComboBox.Text);
                    ErrorsHandling.ShowMessageAndSaveLogWithErrors(e.Message.ToString(), filepath, extenstionSelected);
                }
            }
            */
            #endregion

            SaveLog(logline);

        }
        private void CombineAndSaveLog(int operation_no, int numberofoperations, string operationtype_string, double a, double b, string wynik)
        {
            //and is missing some formatting
            //WM: What kind of formating?
            string logLine = $"Operation : " + operation_no.ToString() + "/" + numberofoperations.ToString() + " | " + a.ToString() + operationtype_string + b.ToString() + " = " + wynik;
            SaveLog(logLine);
        }
        private void SaveLog(string message)
        {
            ErrorLogTB.AppendText(message + "\n");
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(Path.GetDirectoryName(PathTB.Text) + "\\log.txt", true))
            {
                file.WriteLine(message);
            }
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operationtype = "multiplication";
            operationtype_string = "*";
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operationtype = "division";
            operationtype_string = "/";
        }
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operationtype = "exponentiation";
            operationtype_string = "^";
        }
        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operationtype = "subtraction";
            operationtype_string = "-";
        }
        private void RadioDodawanie_CheckedChanged(object sender, EventArgs e)
        {
            operationtype = "adding";
            operationtype_string = "+";
        }
        private void RadioModulo_CheckedChanged(object sender, EventArgs e)
        {
            operationtype = "modulo";
            operationtype_string = "%";
        }

        private void OpenErrorLogButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Process.Start(ofd.FileName);
            }
        }
    }
}