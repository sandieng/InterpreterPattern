namespace InterpreterPattern
{
    public class LettuceIngredient : Ingredient
    {
        public override void Interpret(Context context)
        {
            context.Output += "Lettuce";
        }
    }
}
