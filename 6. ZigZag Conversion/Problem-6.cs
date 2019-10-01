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
            m_Tester.AddTestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI");
            m_Tester.AddTestCase("PAYPALISHIRING", 5, "PHASIYIRPLIGAN");
            m_Tester.AddTestCase("PAYPALISHIRING", 6, "PRAIIYHNPSGAIL");
            m_Tester.AddTestCase("abcdefghijk", 2, "acegikbdfhj");
            m_Tester.AddTestCase("", 1, "");
            m_Tester.AddTestCase("", 2, "");
            m_Tester.AddTestCase("A", 1, "A");
            m_Tester.AddTestCase("A", 2, "A");
            m_Tester.AddTestCase("AB", 1, "AB");
            m_Tester.AddTestCase("AB", 2, "AB");
            m_Tester.AddTestCase("ABC", 1, "ABC");
            m_Tester.AddTestCase("ABC", 2, "ACB");
            m_Tester.AddTestCase("ABC", 3, "ABC");
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