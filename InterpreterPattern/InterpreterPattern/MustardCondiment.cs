namespace InterpreterPattern
{
    public class MustardCondiment : Condiment
    {
        public override void Interpret(Context context)
        {
            context.Output += "Mustard";
        }
    }
}
