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
                MoodAnalyse mood = new MoodAnalyse("");
                    mood.Analyze();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            

        }
    }
}
