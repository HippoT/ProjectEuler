using System;
using System.Linq;
using System.Collections.Generic;
public class Problem3 : IProblem
{
    public double Num { get; set; }
    public Problem3(double num)
    {
        Num = num;
    }
    public void Run()
    {
        DateTime now = DateTime.Now;
        List<double> result = new List<double>();
        List<double> primeNums = new List<double>(){2};
        double index = 3f;
        while (index <= Num)
        {
            if(!primeNums.Any(x => (index / 2) > x && index % x == 0)){
                primeNums.Add(index);
                if(Num % index == 0)
                {
                    Num = Num / index;
                    result.Add(index);
                }
            }
            index += 2;
        }
        var time = DateTime.Now.Subtract(now);
        Console.WriteLine(primeNums.Aggregate("List Prime Nums ", (s, n) => $"{s}; {n}"));
        Console.WriteLine(result.Aggregate("Result ", (s, n) => $"{s}; {n}"));

        Console.WriteLine($"{time.TotalSeconds}");
    }


}