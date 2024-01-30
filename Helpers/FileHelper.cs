using IronXL;
using CodeChallenge.Maps;


namespace JsonProcessor.Helpers
{
    public class FileHelper
    {

        public void CreateCSV(string outputPath,string outputfile, TestResults testData)
        {
            WorkBook workBook = WorkBook.Create(ExcelFileFormat.XLSX);

            string shortDate = DateTime.Now.ToString("MM_dd_yyyy");
    
            string timeOnly = DateTime.Now.ToString("HH-mm-ss tt");
            var workSheet = workBook.CreateWorkSheet($"{shortDate} {timeOnly}");

            int index = 1;

            workSheet["A1"].Value = "name";
            workSheet["B1"].Value = "status";
            workSheet["C1"].Value = "duration";
            workSheet["D1"].Value = "Start Time";
            workSheet["E1"].Value = "End Time";
            workSheet["F1"].Value = "message";

            foreach (var test in testData.Results[0].Tests)
            {
                workSheet[$"A{index + 1}"].Value = test.Name;
                workSheet[$"B{index + 1}"].Value = test.Status;
                workSheet[$"C{index + 1}"].Value = test.Duration;              

                workSheet[$"D{index + 1}"].Value = test.Metrics?.Single(x => x.Name == "Start Time").Value;
                workSheet[$"E{index + 1}"].Value = test.Metrics?.Single(x => x.Name == "End Time").Value;
                workSheet[$"F{index + 1}"].Value = test.Message;
                index++;
            }
            var path = outputPath + outputfile;
            workBook.SaveAs(outputPath+outputfile);
            
        }
    }
}
