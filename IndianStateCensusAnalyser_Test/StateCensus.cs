using IndianStateCensusData_Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IndianStateCensusAnalyser_Test
{
    [TestClass]
    public class StateCensus
    {
        public static string stateCensusCSVFile_Path = @"C:\Users\674\Desktop\Rfp288\IndianStateCensus_Data\IndianStateCensusData_Problem\IndianStateCensusData_Problem\Files\StateCensusData.csv";
        [TestMethod]
        public void MatchFiles()
        {
            IndianStateAnalyser indianStateAnalyser = new IndianStateAnalyser();
            CSV_Census cSV_Census = new CSV_Census();
            Assert.AreEqual(cSV_Census.ReadStateCensusData(stateCensusCSVFile_Path), indianStateAnalyser.ReadStateCnsusData(stateCensusCSVFile_Path));
        }
    }
}
