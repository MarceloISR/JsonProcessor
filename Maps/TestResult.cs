using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Maps
{
    public class TestResults
    {
        public string status { get; set; }
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public List<Test> tests { get; set; }
        public List<Metric> metrics { get; set; }
    }

    public class Test
    {
        public string name { get; set; }
        public string status { get; set; }
        public float duration { get; set; }
        public string message { get; set; }
    }

    public class Metric
    {
        public string name { get; set; }
        public float value { get; set; }
    }
}
