using System.Collections.Generic;
using System;
using solutions;

namespace tester
{
    public interface ILCTesterV2<T1, T2>
    {
        void AddTestCase(T1 input, T2 output);
        void AddTestCase(ILCTestCase<T1, T2> testCase);
        void SetTestCases(List<ILCTestCase<T1, T2>> testCases);
        void SetSolution(ILCSolutionV2<T1, T2> solution);
        void RunTest();
    }
    public class LCTesterV2<T1, T2> : ILCTesterV2<T1, T2>
    {
        List<ILCTestCase<T1, T2>> m_TestCases = new List<ILCTestCase<T1, T2>>();
        List<ILCTestCase<T1, T2>> m_FailedCases = new List<ILCTestCase<T1, T2>>();
        List<int> m_FailedIndexes = new List<int>();
        ILCSolutionV2<T1, T2> m_Solution;

        public LCTesterV2()
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
            m_FailedCases.Clear();
            m_FailedIndexes.Clear();
        }

        public void SetSolution(ILCSolutionV2<T1, T2> solution)
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
                bool correct = RunCase(tc, i);

                if (!correct)
                {
                    m_FailedCases.Add(tc);
                    m_FailedIndexes.Add(i);
                }
            }

            if (m_FailedCases.Count == 0) { return; }
            Console.WriteLine($"> Start Debugging");
            for (var i = 0; i < m_FailedCases.Count; i++)
            {
                var tc = m_FailedCases[i];
                var idx = m_FailedIndexes[i];
                RunCase(tc, idx, true);
            }
        }

        bool RunCase(ILCTestCase<T1, T2> tc, int i, bool verbose = false)
        {
            var input = tc.Input;
            var output = tc.Output;

            if (verbose)
            {
                m_Solution.SetVerbose(true);
            }

            var answer = m_Solution.Solve(input);
            var correct = answer.Equals(output);
            var correctSign = correct ? "O" : "X";
            Console.Write($"\t({correctSign}) ");
            Console.WriteLine($"TestCase({i}): input = {input}, output = {output}, answer = {answer}");
            return correct;
        }
    }
}