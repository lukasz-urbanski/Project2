﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ErrorLogFilePathValidation
    {
        public static string IsValid(string pathToValid)
        {
            try
            {
                Path.GetFullPath(pathToValid);
                return pathToValid;
            }catch
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }
}
