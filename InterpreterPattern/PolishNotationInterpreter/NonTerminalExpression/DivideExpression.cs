namespace PolishNotationInterpreter.NonTerminalExpression
{
    public class DivideExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public DivideExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        int IExpression.Interpret()
        {
            return leftExpression.Interpret() / rightExpression.Interpret();
        }
    }
}
