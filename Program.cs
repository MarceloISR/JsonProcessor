// See https://aka.ms/new-console-template for more information


using CodeChallenge.Maps;
using JsonProcessor;
using JsonProcessor.Helpers;

Console.WriteLine("Welcome");
Console.WriteLine("Add the path to the json file or leave empty for default data");
Console.WriteLine("e.g. D:\\TestData\\TestData.json");
//Read the path to the JSON file or receive empty string
var JSONpath = Console.ReadLine();
TestResults? output = JSONHelper.ReadJSONFile(JSONpath);

Console.WriteLine("Wanna display the metrics? Y/N");
string metrics = Console.ReadLine().ToLower() ?? "y";

Console.WriteLine("Wanna export the JSON to a CSV file? Y/N");
string export = Console.ReadLine().ToLower() ?? "y";

try
{
    

    if (output != null)
    {
        //if the status is success, calculate the metrics
        if (output.Status == "success" )
        {
            
            if( metrics == "y")
            {
                Processor.DisplayMetrics(output);
            }

            
            if ( export == "y")
            {
                FileHelper fileHelper = new FileHelper();
                fileHelper.CreateCSV("../../../Export/", "export.csv", output);
                Console.WriteLine("Document exported");
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