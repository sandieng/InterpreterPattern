using System.Collections.Generic;

namespace InterpreterPattern
{
    public class IngredientList : IExpression
    {
        private readonly List<Ingredient> _ingredients;

        public IngredientList(List<Ingredient> ingredients)
        {
            _ingredients = ingredients;
        }

        public void Interpret(Context context)
        {
            foreach (var ingredient in _ingredients)
            {
                ingredient.Interpret(context);
            }
        }
    }
}