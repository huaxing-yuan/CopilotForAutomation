using AxaFrance.WebEngine;
using HomeInsurrance.KeywordDriven.Tests.TestCases;

namespace HomeInsurrance.KeywordDriven.Tests
{
    /// <summary>
    /// Test Suite is the entry point of the test library. 
    /// In a data driven approach, test instances are created here based on test data.
    /// </summary>
    public class HomeInsuranceTests : TestSuite
    {
        public override KeyValuePair<string, TestCase>[] TestCases => GetTestCases();

        private static KeyValuePair<string, TestCase>[] GetTestCases()
        {
            var testCases = new List<KeyValuePair<string, TestCase>>();
            foreach (var data in TestSuiteData.Current.TestDataList)
            {
                /// In normal practice, test instance is determined by test data,
                /// Here we simplify the example by using a single test case template "SouscriptionAssurance"
                testCases.Add(new KeyValuePair<string, TestCase>(data.TestName, new SouscriptionAssurance()));
            }
            return testCases.ToArray();
        }
    }
}

