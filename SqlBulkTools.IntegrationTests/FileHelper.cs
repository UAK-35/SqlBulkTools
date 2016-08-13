﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBulkTools.IntegrationTests
{
    public class FileHelper
    {
        private const string LogResultsLocation = @"C:\SqlBulkTools_Log.txt";
        public static void AppendToLogFile(string text)
        {
            if (!File.Exists(LogResultsLocation))
            {
                using (StreamWriter sw = File.CreateText(LogResultsLocation))
                {
                    sw.WriteLine(text);
                }

                return;
            }

            using (StreamWriter sw = File.AppendText(LogResultsLocation))
            {
                sw.WriteLine(text);
            }
        }

        public static void DeleteLogFile()
        {
            if (File.Exists(LogResultsLocation))
            {
                File.Delete(LogResultsLocation);
            }
        }
    }
}
