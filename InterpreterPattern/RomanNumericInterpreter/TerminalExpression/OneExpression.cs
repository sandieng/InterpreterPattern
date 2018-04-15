namespace RomanNumericInterpreter.TerminalExpression
{
    public class OneExpression : Expression
    {
        public override int Multiplier()
        {
            return 1;
        }

        public override string One()
        {
            return "I";
        }

        public override string Four()
        {
            return "IV";
        }

        public override string Five()
        {
            return "V";
        }

        public override string Nine()
        {
            return "IX";
        }
    }
}
