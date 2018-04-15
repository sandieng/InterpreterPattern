namespace RomanNumericInterpreter
{
    public class Context
    {
        private string _input;
        private int _output;

        public string Input { get; set; }
        public int Output { get; set; }

        public Context(string input)
        {        
            Input = input;
        }
    }
}
