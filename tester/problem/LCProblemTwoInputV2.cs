using System;
using System.Collections.Generic;
using solutions;
using tester;

namespace problems
{
    public class LCProblemTwoInputV2 : ILCProblemV2
    {
        LCTesterTwoInput<int, int, int> m_Tester;
        Dictionary<int, ILCVerboseSolutionTwoInput<int, int, int>> m_Solutions;

        public LCProblemTwoInputV2()
        {
            m_Solutions = new Dictionary<int, ILCVerboseSolutionTwoInput<int, int, int>>();
        }

        public void RegisterSolutions()
        {
            m_Solutions.Add(0, new LCProblemSolutionTwoInput0());
        }

        public void PrepareTester()
        {
            m_Tester = new LCTesterTwoInput<int, int, int>();
        }
        public void AddTestCase()
        {
            m_Tester.AddTestCase(0, 0, 0);
        }
        public void SetSolution(int solutionIndex)
        {
            if (m_Solutions.ContainsKey(solutionIndex))
            {
                m_Tester.SetSolution(m_Solutions[solutionIndex]);
                return;
            }

            throw new Exception($"Warning! Solution-{solutionIndex} has not yet registerd");
        }
        public void RunTest()
        {
            m_Tester.RunTest();
        }
    }
}