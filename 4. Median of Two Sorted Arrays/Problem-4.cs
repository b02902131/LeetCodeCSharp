using System.Collections.Generic;
using solutions;
using tester;

namespace problems
{
    public class LCProblem4 : ILCProblem
    {
        LCTesterTwoInput<int[], int[], double> m_Tester;
        public void PrepareTester()
        {
            m_Tester = new LCTesterTwoInput<int[], int[], double>();
        }
        public void AddTestCase()
        {
            m_Tester.AddTestCase(new int[] { 1, 3 }, new int[] { 2 }, 2.0f);
            m_Tester.AddTestCase(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5f);
            m_Tester.AddTestCase(new int[] { 1 }, new int[] { 2, 3, 5 }, 2.5f);
        }
        public void SetSolution(int solutionIndex)
        {
            switch (solutionIndex)
            {
                case 0:
                default:
                    {
                        m_Tester.SetSolution(new LCProblem4Solution0());
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