using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusData_Problem
{
    public class Program
    {
        public static string path = @"C:\Users\674\Desktop\Rfp288\IndianStateCensus_Data\IndianStateCensusData_Problem\IndianStateCensusData_Problem\Files\StateCensusData.csv";
        static void Main(string[] args)
        {
            IndianStateAnalyser indianStateAnalyser = new IndianStateAnalyser();
            indianStateAnalyser.ReadStateCnsusData(path);
        }
    }
}
