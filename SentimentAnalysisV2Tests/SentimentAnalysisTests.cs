using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using SentimentAnalysisV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisV2.Tests
{
    [TestClass()]
    public class SentimentAnalysisTests
    {
        [TestMethod()]
        public void GetSentimentScoreTest()
        {

            string afinnFilePath = "AFINN-ru.json";
            JObject afinn = JObject.Parse(File.ReadAllText(afinnFilePath));
            string path = "Да.Этот фильм просто ужасный и жалобный";
            int expected = -4;

            SentimentAnalysis test = new SentimentAnalysis();

            int actual = test.GetSentimentScore(path, afinn);
            Assert.AreEqual(expected, actual);
        }
    }
}