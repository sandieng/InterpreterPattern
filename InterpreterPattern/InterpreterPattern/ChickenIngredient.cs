namespace InterpreterPattern
{
    public class ChickenIngredient : Ingredient
    {
        public override void Interpret(Context context)
        {
            context.Output += "Chicken";
        }
    }
}
