using System.Collections.Generic;
using solutions;
using tester;

namespace problems
{
    public class LCProblemXXX : ILCProblem
    {
        LCTesterV2<string, string> m_Tester;
        public void PrepareTester()
        {
            m_Tester = new LCTesterV2<string, string>();
        }
        public void AddTestCase()
        {
            m_Tester.AddTestCase("example", "example");
        }
        public void SetSolution(int solutionIndex)
        {
            switch (solutionIndex)
            {
                case 0:
                default:
                    {
                        m_Tester.SetSolution(new LCPxxxSolution0());
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