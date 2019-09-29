namespace tester
{
    public interface ILCTestCase
    {
        string Input { get; }
        string Output { get; }
    }

    public class LCTestCase
    {
        string m_Input;
        string m_Output;
        public string Input { get { return m_Input; } }
        public string Output { get { return m_Output; } }

        public LCTestCase(string input, string output)
        {
            m_Input = input;
            m_Output = output;
        }
    }
}