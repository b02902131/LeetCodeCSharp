using System.Collections.Generic;
using System;
using solutions;

namespace tester
{
    public interface ILCTesterTwoInput<T1, T2, T3>
    {
        void AddTestCase(T1 input1, T2 input2, T3 output);
        void AddTestCase(ILCTestCaseTwoInput<T1, T2, T3> testCase);
        void SetTestCases(List<ILCTestCaseTwoInput<T1, T2, T3>> testCases);
        void SetSolution(ILCVerboseSolutionTwoInput<T1, T2, T3> solution);
        void RunTest();
    }

    public class LCTesterTwoInput<T1, T2, T3> : ILCTesterTwoInput<T1, T2, T3>
    {
        List<ILCTestCaseTwoInput<T1, T2, T3>> m_TestCases = new List<ILCTestCaseTwoInput<T1, T2, T3>>();
        List<ILCTestCaseTwoInput<T1, T2, T3>> m_FailedCases = new List<ILCTestCaseTwoInput<T1, T2, T3>>();
        List<int> m_FailedIndexes = new List<int>();
        ILCVerboseSolutionTwoInput<T1, T2, T3> m_Solution;

        public LCTesterTwoInput()
        {
            Console.WriteLine($"> PrepareTester\t: {typeof(T1)}, {typeof(T2)} -> {typeof(T2)}");
        }

        public void AddTestCase(T1 input1, T2 input2, T3 output)
        {
            LCTestCaseTwoInput<T1, T2, T3> testCase = new LCTestCaseTwoInput<T1, T2, T3>(input1, input2, output);
            m_TestCases.Add(testCase);
        }

        public void AddTestCase(ILCTestCaseTwoInput<T1, T2, T3> testCase)
        {
            m_TestCases.Add(testCase);
        }

        public void SetTestCases(List<ILCTestCaseTwoInput<T1, T2, T3>> testCases)
        {
            m_TestCases = testCases;
            m_FailedCases.Clear();
            m_FailedIndexes.Clear();
        }

        public void SetSolution(ILCVerboseSolutionTwoInput<T1, T2, T3> solution)
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

            RunDebug();
        }

        public void RunDebug()
        {
            if (m_FailedCases.Count == 0) { return; }
            Console.WriteLine($"> Start Debugging");
            for (var i = 0; i < m_FailedCases.Count; i++)
            {
                var tc = m_FailedCases[i];
                var idx = m_FailedIndexes[i];
                RunCase(tc, idx, true);
            }
        }

        bool RunCase(ILCTestCaseTwoInput<T1, T2, T3> tc, int i, bool verbose = false)
        {
            var input1 = tc.Input1;
            var input2 = tc.Input2;
            var output = tc.Output;

            if (verbose)
            {
                m_Solution.SetVerbose(true);
            }

            var answer = m_Solution.Solve(input1, input2);
            var correct = answer.Equals(output);
            var correctSign = correct ? "O" : "X";
            Console.Write($"\t({correctSign}) ");
            Console.WriteLine($"TestCase({i}): input = {input1}, {input2}, output = {output}, answer = {answer}");
            return correct;
        }
    }
}