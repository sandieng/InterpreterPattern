namespace RomanNumericInterpreter.TerminalExpression
{
    public class ThousandExpression : Expression
    {            
        public override int Multiplier()
        {
            return 1000;
        }
    
        public override string One()
        {
            return "M";
        }

        public override string Four()
        {
            return " ";
        }

        public override string Five()
        {
            return " ";
        }

        public override string Nine()
        {
            return " ";
        }
    }
}
