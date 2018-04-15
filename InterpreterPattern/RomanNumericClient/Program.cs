using RomanNumericInterpreter;
using RomanNumericInterpreter.TerminalExpression;
using System;
using System.Collections.Generic;

namespace RomanNumericClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Roman numbers
            // M = 1000
            // CM = 900, MC = 1100
            // D = 500
            // CD = 400, DC = 600
            // C = 100
            // XC = 90, XC = 110
            // L = 50
            // XL = 40, LX = 60
            // X = 10
            // IX = 9, XI = 11
            // V = 5
            // IV = 4, VI = 6
            // I = 1
            //
            // Examples: 1969 = MCMLXIX, 2025 = MMXXV, 1476 = MCDLXXVI

            List<Expression> tree = new List<Expression>()
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            string romanNumeral = "";
            Context context = null;

            do
            {
                Console.Write("Enter a roman numeral: ");
                romanNumeral = Console.ReadLine();
                context = new Context(romanNumeral);

                foreach (var expression in tree)
                {
                    expression.Interpret(context);
                }

                Console.WriteLine($"{romanNumeral} = {context.Output}");

            } while (!string.IsNullOrEmpty(romanNumeral));
        }
    }
}
