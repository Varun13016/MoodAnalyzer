using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProgram;

namespace MoodAnalyzer_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void msgSadMood()
        {
            string msg = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyzer mood = new MoodAnalyzer();

            string actual = mood.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void msgHaapyMood()
        {
            string msg = "I am in Any mood";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer();

            string actual = mood.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
        }

    }
}
