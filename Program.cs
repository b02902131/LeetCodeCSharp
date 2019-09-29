using System;
using tester;
using problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int problemIndex = 0;
            int solutionIndex = 0;

            if (args.Length > 0) { problemIndex = Int32.Parse(args[0]); }
            if (args.Length > 1) { solutionIndex = Int32.Parse(args[1]); }
            Console.WriteLine($"Run Problem-{problemIndex} with Solution-{solutionIndex}");

            var problem = GetProblem(problemIndex);
            problem.PrepareTester();
            problem.AddTestCase();
            problem.SetSolution(solutionIndex);
            problem.RunTest();
        }

        static ILCProblem GetProblem(int index)
        {
            switch (index)
            {
                case 7:
                    {
                        return new LCProblem7();
                    }
                case 8:
                    {
                        return new LCProblem8();
                    }
                default:
                    {
                        Console.WriteLine($"Warning! Problem-{index} has not yet added into GetProblem()");
                        return new TestProblem();
                    }
            }
        }
    }
}
