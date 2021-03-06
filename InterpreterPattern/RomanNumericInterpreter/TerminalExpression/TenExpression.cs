﻿namespace RomanNumericInterpreter.TerminalExpression
{
    public class TenExpression : Expression
    {
        public override int Multiplier()
        {
            return 10;
        }

        public override string One()
        {
            return "X";
        }

        public override string Four()
        {
            return "XL";
        }

        public override string Five()
        {
            return "L";
        }

        public override string Nine()
        {
            return "XC";
        }
    }
}
