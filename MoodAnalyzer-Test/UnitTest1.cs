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
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalyzer obj = new MoodAnalyzer(msg);

            string actual = obj.AnalyseMood();

            Assert.AreEqual(expected, actual);

        }
    }
}
