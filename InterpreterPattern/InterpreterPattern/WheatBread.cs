namespace InterpreterPattern
{
    public class WheatBread : Bread
    {
        public override void Interpret(Context context)
        {
            context.Output += "Wheat bread";
        }
    }
}
