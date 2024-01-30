
# Project Test Result Analysis

Given a JSON file with a known structure described below, process the data from the json, export the data to a csv file, and generate various metrics based on the test results.

load the project in Visual Studio Community 2022, debug or release the project, a console will be displayed and will ask questions about 
- Select the json file (currently exists a example in the project)
- Display the metrics (select Yes or No)
- Export the tests into a csv ( the file will be stored in the path "bin\Debug\net8.0")

## Packages used
- [IronXL](https://ironsoftware.com/csharp/excel/object-reference/api/), Read Excel Files without Interop
- [Newtonsoft](https://www.newtonsoft.com/json), Popular high-performance JSON framework for .NET

## Metrics Calculations
The project is calculating
- Total number of test cases executed
- Number of test cases Passed
- Number of test cases Failed
- Number of test cases Skipped
- Average Execution time among all test cases
- Minimun Execution time amoung all test cases
- Maximun Execution time amoung all test cases

# JSON Structure

### Top-level :

- **status** (string): "success" or "error"
- **results** (list): list of result objects
- **message** (string): text with current message about the status if exists

### Result Object
- **tests** (list): list of test objects
    - **name** (string): Name of the test
    - **status** (string): "success", "error", or "skip"
    - **duration** (float): Duration of the test execution in seconds
    - **message** (string): Optional message about the test result (may be null)
    - **metrics** (list): list of metric objects
        - **name** (string): Name of the metric
        - **value** (float): Value of the metric
## Related

Here are some related projects

[Awesome README](https://github.com/matiassingers/awesome-readme)

