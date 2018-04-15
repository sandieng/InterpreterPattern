namespace InterpreterPattern
{
    public class WhiteBreadk : Bread
    {
        public override void Interpret(Context context)
        {
            context.Output += "White bread";
        }
    }
}
