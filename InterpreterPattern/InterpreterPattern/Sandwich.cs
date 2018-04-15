using System;

namespace InterpreterPattern
{
    public class Sandwich : IExpression
    {
        private readonly Bread _topBread;
        private readonly CondimentList _topCondiments;
        private readonly IngredientList _ingredients;
        private readonly CondimentList _bottomCondiments;
        private readonly Bread _bottomBread;

        // BNF for a sandwich
        // <sandwich> ::= <bread> <condimenList> <ingredientList> <condimentList> <bread>
        // <condimentList> ::= { <condiment> }
        // <ingredientList> ::= { <ingredient> }
        // <bread> ::= <whiteBread> | <wheatBread>
        // <condiment> ::= <mayoCondiment> | <mustardCondiment> | <ketchupCondiment>
        // <ingredient> ::= <lettuceIngredient> | <tomatoIngredient> | <chickenIngredient>
        public Sandwich(Bread topBread, CondimentList topCondiments, IngredientList ingredients, CondimentList bottomCondiments, Bread bottomBread)
        {
            _topBread = topBread;
            _topCondiments = topCondiments;
            _ingredients = ingredients;
            _bottomCondiments = bottomCondiments;
            _bottomBread = bottomBread;
        }

        public void Interpret(Context context)
        {
            context.Output += "|";
            _topBread.Interpret(context);
            context.Output += "|";
            context.Output += "<--";
            _topCondiments.Interpret(context);
            context.Output += "-";
            _ingredients.Interpret(context);
            context.Output += "-";
            _bottomCondiments.Interpret(context);
            context.Output += "-->";
            context.Output += "|";
            _bottomBread.Interpret(context);
            context.Output += "|";

            Console.WriteLine(context.Output);
        }
    }
}
