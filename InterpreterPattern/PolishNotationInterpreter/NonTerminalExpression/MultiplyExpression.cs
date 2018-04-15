using System;

namespace PolishNotationInterpreter.NonTerminalExpression
{
    public class MultiplyExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public MultiplyExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        int IExpression.Interpret()
        {
            return leftExpression.Interpret() * rightExpression.Interpret();
        }
    }
}
