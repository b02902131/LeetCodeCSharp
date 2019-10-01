namespace tester
{
    public interface ILCTestCaseTwoInput<T1, T2, T3>
    {
        T1 Input1 { get; }
        T2 Input2 { get; }
        T3 Output { get; }
    }

    public class LCTestCaseTwoInput<T1, T2, T3> : ILCTestCaseTwoInput<T1, T2, T3>
    {
        T1 m_Input1;
        T2 m_Input2;
        T3 m_Output;
        public T1 Input1 { get { return m_Input1; } }
        public T2 Input2 { get { return m_Input2; } }
        public T3 Output { get { return m_Output; } }

        public LCTestCaseTwoInput(T1 input1, T2 input2, T3 output)
        {
            m_Input1 = input1;
            m_Input2 = input2;
            m_Output = output;
        }
    }
}