using System.Collections.Generic;
using tester;
using solutions;

namespace problems
{
    public class LCProblem7 : ILCProblem
    {
        LCTester<string, string> m_Tester;
        public LCProblem7() { }

        public void PrepareTester()
        {
            m_Tester = new LCTester<string, string>();
        }
        public void AddTestCase()
        {
            m_Tester.AddTestCase("123", "321");
            m_Tester.AddTestCase("-123", "-321");
            m_Tester.AddTestCase("120", "21");
        }

        public void SetSolution(int solutionIndex)
        {
            // m_Tester.SetSolution();
            switch (solutionIndex)
            {
                case 0:
                default:
                    {
                        m_Tester.SetSolution(new LCP7Solution0());
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