using System.Collections.Generic;
using tester;
using solutions;

namespace problems
{
    public class LCProblem8 : ILCProblem
    {
        LCTester<string, int> m_Tester;
        public LCProblem8() { }

        public void PrepareTester()
        {
            m_Tester = new LCTester<string, int>();
        }
        public void AddTestCase()
        {
            m_Tester.AddTestCase("42", 42);
            m_Tester.AddTestCase("-42", -42);
            m_Tester.AddTestCase("4193 with words", 4193);
            m_Tester.AddTestCase("words and 987", 0);
            m_Tester.AddTestCase("-91283472332", -2147483648);
        }

        public void SetSolution(int solutionIndex)
        {
            // m_Tester.SetSolution();
            switch (solutionIndex)
            {
                case 0:
                default:
                    {
                        m_Tester.SetSolution(new LCP8Solution0());
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