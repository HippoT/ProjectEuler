using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
public class Problem4 : IProblem
{
    private int _lenNum { get; set; }
    public Problem4(int lenNum)
    {
        _lenNum = lenNum;
    }
    public void Run()
    {
        int p1 = GetMaxNum();
        int p2 = p1;
        int maxProduct = p1 * p2;
        int minNum = GetMinNum();
        int stopPoint = minNum * minNum;

        List<int> result = new List<int>();
        for (int i = maxProduct; i > stopPoint; i--)
        {
            var num = i.ToString();
            if(String.Concat(num.Reverse()) == num){
                for (int j = p1; j > minNum; j--)   {
                    if(i % j == 0 && (i / j).ToString().Count() == _lenNum){
                        result.Add(j);
                        result.Add(i / j);
                        result.Add(i);
                        Console.WriteLine(result.Aggregate("Result ", (s, n) => $"{s}; {n}"));
                        return;
                    }

                }
            }
        }

    }
    
    public int GetMaxNum(){
        var num = new String('9', _lenNum);
        return Convert.ToInt32(num);
    }

    public int GetMinNum(){
        int result = 1;
        for (int i = 1; i < _lenNum; i++)
        {
            result *= 10;
        }
        return result;
    }
}