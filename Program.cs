using System;
using System.Collections.Generic;
using tester;
using problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static Dictionary<int, ILCProblem> m_Problems;

        static void RegisterProblems()
        {
            m_Problems = new Dictionary<int, ILCProblem>();
            m_Problems.Add(4, new LCProblem4());
            m_Problems.Add(6, new LCProblem6());
            m_Problems.Add(7, new LCProblem7());
            m_Problems.Add(8, new LCProblem8());
            m_Problems.Add(999, new LCProblemTwoInputExample());
        }

        static void Main(string[] args)
        {
            RegisterProblems();

            int problemIndex = 0;
            int solutionIndex = 0;

            if (args.Length > 0)
            {
                if (args[0] == "all")
                {
                    RunAllProblems();
                    System.Environment.Exit(0);
                }
                problemIndex = Int32.Parse(args[0]);
            }

            if (args.Length > 1) { solutionIndex = Int32.Parse(args[1]); }

            RunProblem(problemIndex, solutionIndex);
        }

        static void RunProblem(int problemIndex, int solutionIndex)
        {
            Console.WriteLine($"Run Problem-{problemIndex} with Solution-{solutionIndex}");
            var problem = GetProblem(problemIndex);
            problem.PrepareTester();
            problem.AddTestCase();
            problem.SetSolution(solutionIndex);
            problem.RunTest();
        }

        static void RunAllProblems()
        {
            foreach (var k in m_Problems.Keys)
            {
                RunProblem(k, 0);
            }
        }

        static ILCProblem GetProblem(int index)
        {
            if (m_Problems.ContainsKey(index))
            {
                return m_Problems[index];
            }

            throw new Exception($"Warning! Problem-{index} has not yet added into GetProblem()");
        }
    }
}
