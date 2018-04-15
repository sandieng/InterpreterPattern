namespace RomanNumericInterpreter.TerminalExpression
{
    public class HundredExpression : Expression
    {
        public override int Multiplier()
        {
            return 100;
        }

        public override string One()
        {
            return "C";
        }

        public override string Four()
        {
            return "CD";
        }

        public override string Five()
        {
            return "D";
        }

        public override string Nine()
        {
            return "CM";
        }
    }
}
