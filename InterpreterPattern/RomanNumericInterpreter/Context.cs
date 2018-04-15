namespace RomanNumericInterpreter
{
    public class Context
    {
        private string _input;
        private int _output;

        public Context(string input)
        {
            _input = input;
        }

        public string GetInput()
        {
            return _input;
        }

        public void SetInput(string input)
        {
            _input = input;
        }

        public int GetOutput()
        {
            return _output;
        }

        public void SetOutput(int output)
        {
            _output = output;
        }
    }
}
