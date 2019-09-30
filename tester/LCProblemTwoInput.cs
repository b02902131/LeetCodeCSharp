using System.Collections.Generic;
using solutions;
using tester;

namespace problems
{
    public class LCProblemTwoInputExample : ILCProblem
    {
        LCTesterTwoInput<string, string, string> m_Tester;
        public void PrepareTester()
        {
            m_Tester = new LCTesterTwoInput<string, string, string>();
        }
        public void AddTestCase()
        {
            m_Tester.AddTestCase("example", "example", "example");
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