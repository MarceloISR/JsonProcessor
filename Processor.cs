using CodeChallenge.Maps;


namespace JsonProcessor
{
    public class Processor
    {

        public static void DisplayMetrics(TestResults testResults)
        {
            Console.WriteLine($"JSON Status = {testResults.Status}");
            var tests = testResults?.Results?[0].Tests;

            if (tests != null)
            {
                Console.WriteLine($"Total number of test cases Executed = {CalculateTotalTestExecuted(tests)}");
                Console.WriteLine($"Number of Test Cases Passed = {CalculateTestPassed(tests)}");
                Console.WriteLine($"Number of Test Cases Failed = {CalculateTestFailed(tests)}");
                Console.WriteLine($"Number of Test Cases Skipped = {CalculateTestSkipped(tests)}");

                Console.WriteLine($"Averate execution time={CalulateAverageDuration(tests)}");
                Console.WriteLine($"Maximun execution time among all test cases = {CalculateMaximunDuration(tests)}");
                Console.WriteLine($"Minimun execution time among all test cases = {CalculateMinimumDuration(tests)}");
            }
        }

        /// <summary>
        /// Calculate the Average execution time for all test cases
        /// </summary>
        /// <param name="tests"> list of tests cases executed</param>
        /// <returns>Float: Average time</returns>
        private static float CalulateAverageDuration(List<Test> tests)
        {
            float AverageTime = 0;
            AverageTime = (float)tests.Where(x => x.Status!="skipped").Select(x => x.Duration).Average();
            return AverageTime;
        }

        /// <summary>
        /// Calculate the total number of test cases  executed
        /// </summary>
        /// <param name="tests"> list of tests cases executed</param>
        /// <returns>Integer: Number of test cases executed</returns>
        private static int CalculateTotalTestExecuted(List<Test>? tests)
        {
            return tests?.Count ?? 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tests"> list of tests cases executed</param>
        /// <returns>Float: Minimun execution time</returns>
        private static float CalculateMinimumDuration(List<Test>? tests)
        {
            float minimun = (float)tests.Where(x => x.Status != "skipped").Select(y => y.Duration).Min();
            return minimun;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tests"> list of tests cases executed</param>
        /// <returns>Float: Maximun execution time</returns>
        private static float CalculateMaximunDuration(List<Test> tests)
        {
            float maximun = (float)tests.Where(x => x.Status != "skipped").Select(y => y.Duration).Max();
            return maximun;
        }

        /// <summary>
        /// Calculate the Number of test cases Failed
        /// </summary>
        /// <param name="tests"> list of tests cases executed</param>
        /// <returns>Integer: Number of test cases failed</returns>
        private static int CalculateTestFailed(List<Test> tests)
        {
            return tests.Count(x => x.Status == "error");
        }

        /// <summary>
        /// Calculate the number of test cases Passed
        /// </summary>
        /// <param name="tests"> list of tests cases executed</param>
        /// <returns>Integer: Number of test cases Passed</returns>
        private static int CalculateTestPassed(List<Test> tests)
        {
            return tests.Count(x => x.Status == "success");
        }

        /// <summary>
        /// Calculate the number of test cases Skipped
        /// </summary>
        /// <param name="tests"> list of tests cases executed</param>
        /// <returns>Integer: Number of test cases skipped</returns>
        private static int CalculateTestSkipped(List<Test> tests) {
            return tests.Count(x => x.Status == "skipped");
        }
    }
}
