using System.Collections.Generic;
using solutions;

namespace tester
{
    public interface ILCProblem
    {
        void PrepareTester();
        void AddTestCase();
        void SetSolution(int solutionIndex);
        void RunTest();
    }

    public class TestProblem : ILCProblem
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
                        m_Tester.SetSolution(new LCP8xxxolution0());
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