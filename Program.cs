using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgragram
{
    internal class Program
    {

        public static void Main(string[] args)
        {


            try
            {
                MoodAnalyze mood = new MoodAnalyze("");
                mood.Analyze();
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
