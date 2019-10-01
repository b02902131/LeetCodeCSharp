using System.Collections.Generic;
using solutions;
using tester;

namespace problems
{
    public class LCProblemTwoInputExample : ILCProblem
    {
        LCTesterTwoInput<int, int, int> m_Tester;
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
            switch (solutionIndex)
            {
                case 0:
                default:
                    {
                        m_Tester.SetSolution(new LCProblemSolutionTwoInput0());
                        break;
                    }
            }
        }
        public void RunTest()
        {
            m_Tester.RunTest();
        }
    }
}