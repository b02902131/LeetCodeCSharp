using System.Collections.Generic;
using tester;
using solutions;

namespace problems
{
    public class LCProblem8 : ILCProblem
    {
        LCTesterV2<string, int> m_Tester;
        public LCProblem8() { }

        public void PrepareTester()
        {
            m_Tester = new LCTesterV2<string, int>();
        }
        public void AddTestCase()
        {
            m_Tester.AddTestCase("", 0);
            m_Tester.AddTestCase(" 2", 2);
            m_Tester.AddTestCase("a", 0);
            m_Tester.AddTestCase("+", 0);
            m_Tester.AddTestCase("-", 0);
            m_Tester.AddTestCase("-+1", 0);
            m_Tester.AddTestCase("+42", 42);
            m_Tester.AddTestCase("42", 42);
            m_Tester.AddTestCase(" 42", 42);
            m_Tester.AddTestCase("   -42", -42);
            m_Tester.AddTestCase("-42", -42);
            m_Tester.AddTestCase("4193 with words", 4193);
            m_Tester.AddTestCase("words and 987", 0);
            m_Tester.AddTestCase("2147483646", 2147483646);
            m_Tester.AddTestCase("2147483647", 2147483647);
            m_Tester.AddTestCase("2147483648", 2147483647);
            m_Tester.AddTestCase("91283472332", 2147483647);
            m_Tester.AddTestCase("-2147483647", -2147483647);
            m_Tester.AddTestCase("-2147483648", -2147483648);
            m_Tester.AddTestCase("-2147483649", -2147483648);
            m_Tester.AddTestCase("2147483800", 2147483647);
            m_Tester.AddTestCase("-91283472332", -2147483648);
            m_Tester.AddTestCase("  0000000000012345678", 12345678);
            m_Tester.AddTestCase("-000000000000001", -1);
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