using PolishNotationInterpreter.NonTerminalExpression;
using System.Collections.Generic;
using System.Linq;

namespace PolishNotationInterpreter
{
    public class TokenReader
    {
        public IExpression ReadToken(List<string> tokenList)
        {
            return ReadNextToken(tokenList);
        }

        private IExpression ReadNextToken(List<string> tokenList)
        {
            int i;

            if (int.TryParse(tokenList.First(), out i))  // If the token is integer (terminal)
            {
                tokenList.RemoveAt(0);   // Process terminal expression
                return new NumberExpression(i);
            }
           
            return ReadNonTerminal(tokenList);  // Process nonTerminal expression       
        }

        private IExpression ReadNonTerminal(List<string> tokenList)
        {
            string token = tokenList.First();
            tokenList.RemoveAt(0);   // Read the symbol
            IExpression left = ReadNextToken(tokenList); // Read left expression
            IExpression right = ReadNextToken(tokenList);  // Read right expression

            if (token == "+")
                return new AddExpression(left, right);

            if (token == "-")
                return new SubtractExpression(left, right);

            if (token == "*")
                return new MultiplyExpression(left, right);

            if (token == "/")
                return new DivideExpression(left, right);

            return null;
        }
    }
}
