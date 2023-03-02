using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyserProgragram.MoodAnalyse;

namespace MoodAnalyserProgragram
{
    internal class Program
    {

        public static void Main(string[] args)
        {


            try
            {
                AnalyzeMood mood = new AnalyzeMood("");
                mood.Analyze();
            }
            catch (MoodAnalyzeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
