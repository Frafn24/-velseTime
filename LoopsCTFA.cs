using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ØvelseTime2._2
{
    internal class LoopsCTFA
    {
    
        public void main()
        {
            List<grader> graders = new List<grader>();
            double totalFahrenheit = 0;
            double totalCelsius = 0;
            for (int i = 40; i > -6; i--) 
            {
                var Tf = 32 + (9 / 5 * i);
                graders.Add(new grader { celsius = i, Fahrenheit =Tf});
            }
            foreach (var grader in graders)
            {
                Console.WriteLine($"celsius:{grader.celsius}°C");
                Console.WriteLine($"Fahrenheit:{grader.Fahrenheit}°F");
                Console.WriteLine();
            }
            foreach (var grader in graders)
            {
                totalFahrenheit += grader.Fahrenheit;
                totalCelsius += grader.celsius;

            }
            Console.WriteLine($"Genmmslitlige grader i Celsius: {totalCelsius / graders.Count()}°C");
            Console.WriteLine($"Genmmslitlige grader i Fahrenheit: {totalFahrenheit / graders.Count()}°F");
        }
        
    }
    public class grader
    {
        public double Fahrenheit { get; set; }
        public double celsius { get; set; }
    }   
}

