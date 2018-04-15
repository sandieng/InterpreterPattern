namespace InterpreterPattern
{
    public class TomatoIngredient : Ingredient
    {
        public override void Interpret(Context context)
        {
            context.Output += "Tomato";
        }
    }
}
