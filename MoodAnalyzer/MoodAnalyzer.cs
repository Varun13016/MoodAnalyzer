using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyzer
    {
        public string msg;
       
        public string AnalyseMood(string msg)
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";

            else
                return "HAPPY";
        }

    }
}