// See https://aka.ms/new-console-template for more information


using CodeChallenge.Maps;
using JsonProcessor;
using JsonProcessor.Helpers;

Console.WriteLine("Welcome");
Console.WriteLine("Add the path to the json file or leave empty for default data");
Console.WriteLine("e.g. D:\\TestData\\TestData.json");

Console.WriteLine("Wanna display the metrics? Y/N");
string metrics = Console.ReadLine() ?? "Y";

Console.WriteLine("Wanna export the JSON to a CSV file? Y/N");
string export = Console.ReadLine() ?? "Y";

try
{
    //Read the path to the JSON file or receive empty string
    var JSONpath = Console.ReadLine();
    TestResults? output = JSONHelper.ReadJSONFile(JSONpath);

    if (output != null)
    {
        //if the status is success, calculate the metrics
        if (output.Status == "success" )
        {
            
            if( metrics == "Y")
            {
                Processor.DisplayMetrics(output);
            }

            
            if ( export == "Y")
            {
                FileHelper fileHelper = new FileHelper();
                fileHelper.CreateCSV("../../export/", "export.csv", output);
            }

        }
        else //if not display the message from the json
        {
            Console.WriteLine($"Message = {output.Message}");
        }
    }
}
catch (Exception)
{
    throw new Exception();
};