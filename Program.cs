using System;
using System.Collections.Generic;
using tester;
using problems;

namespace LeetCodeCSharp
{
    class Program
    {
        static Dictionary<int, ILCProblemV2> m_Problems;

        static void RegisterProblemV1(int index, ILCProblem problem)
        {
            m_Problems.Add(index, new LCProblemV1V2Adapter(problem));
        }

        static void RegisterProblemV2(int index, ILCProblemV2 problemV2)
        {
            m_Problems.Add(index, problemV2);
        }

        static void RegisterProblemsV1()
        {
            RegisterProblemV1(4, new LCProblem4());
            RegisterProblemV1(6, new LCProblem6());
            RegisterProblemV1(7, new LCProblem7());
            RegisterProblemV1(8, new LCProblem8());
            RegisterProblemV1(999, new LCProblemTwoInputExample());
        }

        static void RegisterProblemsV2()
        {
            RegisterProblemV2(998, new LCProblemTwoInputV2());
        }
        static void RegisterProblems()
        {
            m_Problems = new Dictionary<int, ILCProblemV2>();
            RegisterProblemsV1();
            RegisterProblemsV2();
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
            problem.RegisterSolutions();
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

        static ILCProblemV2 GetProblem(int index)
        {
            if (m_Problems.ContainsKey(index))
            {
                return m_Problems[index];
            }

            throw new Exception($"Warning! Problem-{index} has not yet registerd");
        }
    }
}
