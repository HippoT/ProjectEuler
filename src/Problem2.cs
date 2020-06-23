using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Problem2 : IProblem
{
    public void Run(){
        BigInteger startVal = 1;
        BigInteger nextVal = 2;
        BigInteger limit = 400000000000;
        BigInteger tempVal = 0;
        BigInteger result = 0;
        List<BigInteger> listVal = new List<BigInteger>();

        while (nextVal < limit)
        {
            tempVal = nextVal;
            nextVal += startVal;
            //listVal.Add(nextVal);
            if(nextVal % 2 == 0){
                result += nextVal;
            }
            startVal = tempVal;
        }

        //var text = listVal.Aggregate("", (s, n) => s + "; " + n);
        
        //Console.WriteLine(text);
        Console.WriteLine($"result: {result}; previous value: {startVal}; Next value: {nextVal};");
    }
    
}