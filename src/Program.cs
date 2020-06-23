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
            IProblem problem = new Problem3(600851475143);
            problem.Run();
        }
    }
}
