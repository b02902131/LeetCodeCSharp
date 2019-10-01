namespace tester
{
    public interface ILCTestCase<T1, T2>
    {
        T1 Input { get; }
        T2 Output { get; }
    }

    public class LCTestCase<T1, T2> : ILCTestCase<T1, T2>
    {
        T1 m_Input;
        T2 m_Output;
        public T1 Input { get { return m_Input; } }
        public T2 Output { get { return m_Output; } }

        public LCTestCase(T1 input, T2 output)
        {
            m_Input = input;
            m_Output = output;
        }
    }
}