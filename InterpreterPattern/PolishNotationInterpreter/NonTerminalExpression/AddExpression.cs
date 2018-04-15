namespace PolishNotationInterpreter
{
    public class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        // public int Interpret() {...}
        int IExpression.Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }
}
