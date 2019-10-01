using System.Collections.Generic;
using solutions;
using tester;

namespace problems
{
    public class LCProblem6 : ILCProblem
    {
        LCTesterTwoInput<string, int, string> m_Tester;
        public void PrepareTester()
        {
            m_Tester = new LCTesterTwoInput<string, int, string>();
        }
        public void AddTestCase()
        {
            m_Tester.AddTestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR");
        }
        public void SetSolution(int solutionIndex)
        {
            switch (solutionIndex)
            {
                case 0:
                default:
                    {
                        m_Tester.SetSolution(new LCProblem6Solution0());
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