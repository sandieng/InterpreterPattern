namespace InterpreterPattern
{
    public class MayoCondiment : Condiment
    {
        public override void Interpret(Context context)
        {
            context.Output += "Mayo";
        }
    }
}
