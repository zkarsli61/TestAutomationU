using NUnit.Framework;

namespace TestingWithNunit.Tests
{
    public class TestData
    {
        public static string[] CurrencyStrings()
        {
            return new[]
            {
                "88",
                "$88",
                "88.0",
                "88.0",
                "88.0"
            };
        }
        public static object[] RoomInfo()
        {
            return new object[]
            {
                    new object[] {"1","100",RoomType.Double},
                    new object[] {"2","200",RoomType.Family}
            };
        }
        public static TestCaseData[] RoomTestCaseData()
        {
            return new TestCaseData[]
            {
                    new TestCaseData("1","100",RoomType.Double)
                    .SetName("double room").SetDescription("description"),
                    new TestCaseData("2","200",RoomType.Family)
                    .SetCategory("Family").Explicit()
            };
        }


    }
}
