using CodeChallenge.Maps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProcessor
{
    public class JSONHelper
    {

        /// <summary>
        /// Method to Read the json file 
        /// </summary>
        /// <param name="jsonFilePath">string: a text with the path to the JSON file</param>
        /// <returns>parsed Object from JSON file</returns>
        public static TestResults? ReadJSONFile(string? jsonFilePath= null)
        {
            string jsonPath = string.IsNullOrWhiteSpace(jsonFilePath) ? "../../../TestData/TestData.json" : jsonFilePath;
         
            var jsonData = File.ReadAllText(jsonPath);

            return DeserializeJSONData(jsonData);
        }

        /// <summary>
        /// Parse JSON data to an Object
        /// </summary>
        /// <param name="jsonData"></param>
        /// <returns></returns>
        private static TestResults? DeserializeJSONData(string jsonData) {
            return JsonConvert.DeserializeObject<TestResults>(jsonData);
        }

        /// <summary>
        /// Parse TestResult object to JSON Format
        /// </summary>
        /// <param name="testResults"></param>
        private static void SerializeJSONData(TestResults testResults)
        {
            //Person person = new Person { Name = "John Doe", Age = 30 };
            //string json = JsonConvert.SerializeObject(person);
            //Console.WriteLine(json); // Output: {"Name":"John Doe","Age":30

        }

    }
}
