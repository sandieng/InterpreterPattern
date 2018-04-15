namespace PolishNotationInterpreter
{
    public class NumberExpression : IExpression
    {
        int number;
        public NumberExpression(int i)
        {
            number = i;
        }

        // public int Interpret() {...}
        int IExpression.Interpret()
        {
            return number;
        }
    }
}
