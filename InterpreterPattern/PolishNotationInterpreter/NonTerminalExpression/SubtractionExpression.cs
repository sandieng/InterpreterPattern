namespace PolishNotationInterpreter
{
    public class SubtractExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        // public int Interpret() {...}
        int IExpression.Interpret()
        {
            return leftExpression.Interpret() - rightExpression.Interpret();
        }
    }
}
