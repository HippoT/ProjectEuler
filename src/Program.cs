using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            
            IProblem problem = new Problem4(3);
            problem.Run();

            var time = DateTime.Now.Subtract(now);
             Console.WriteLine($"{time.TotalSeconds}");
        }
    }
}
