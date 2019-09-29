using System.Collections.Generic;
using System;
using solutions;

namespace tester
{
    public interface ILCTester<T1, T2>
    {
        void AddTestCase(T1 input, T2 output);
        void AddTestCase(ILCTestCase<T1, T2> testCase);
        void SetTestCases(List<ILCTestCase<T1, T2>> testCases);
        void SetSolution(ILCSolution<T1, T2> solution);
        void RunTest();
    }

    public class LCTester<T1, T2> : ILCTester<T1, T2>
    {
        List<ILCTestCase<T1, T2>> m_TestCases = new List<ILCTestCase<T1, T2>>();
        ILCSolution<T1, T2> m_Solution;

        public LCTester()
        {
            Console.WriteLine($"> PrepareTester\t: {typeof(T1)} -> {typeof(T2)}");
        }

        public void AddTestCase(T1 input, T2 output)
        {
            LCTestCase<T1, T2> testCase = new LCTestCase<T1, T2>(input, output);
            m_TestCases.Add(testCase);
        }

        public void AddTestCase(ILCTestCase<T1, T2> testCase)
        {
            m_TestCases.Add(testCase);
        }

        public void SetTestCases(List<ILCTestCase<T1, T2>> testCases)
        {
            m_TestCases = testCases;
        }

        public void SetSolution(ILCSolution<T1, T2> solution)
        {
            Console.WriteLine($"> Set Solution\t: {solution.GetType().Name}");
            m_Solution = solution;
        }
        public void RunTest()
        {
            Console.WriteLine($"> Start Testing");
            for (var i = 0; i < m_TestCases.Count; i++)
            {
                var tc = m_TestCases[i];
                var input = tc.Input;
                var output = tc.Output;
                var answer = m_Solution.Solve(input);
                var correct = answer.Equals(output) ? "O" : "X";
                Console.Write($"\t({correct}) ");
                Console.WriteLine($"TestCase({i}): input = {input}, output = {output}, answer = {answer}");
            }
        }
    }
}