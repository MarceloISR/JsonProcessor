using ClosedXML.Excel;
using CodeChallenge.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace JsonProcessor.Helpers
{
    public class FileHelper
    {

        public void CreateCSV(string outputfile, string outputPath, TestResults testData)
        {
            using (var writer = new StreamWriter($"{outputPath}/{outputfile}"))

            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(JSONHelper.SerializeJSONData(testData));
            }
        }
    }
}
