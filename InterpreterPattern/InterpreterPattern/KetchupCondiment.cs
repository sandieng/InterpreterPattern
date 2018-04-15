namespace InterpreterPattern
{
    public class KetchupCondiment : Condiment
    {
        public override void Interpret(Context context)
        {
            context.Output += "Ketchup";
        }
    }
}
