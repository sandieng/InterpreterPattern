namespace RomanNumericInterpreter
{
    public abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.GetInput().Length == 0)
            {
                return;
            }

            if (context.GetInput().StartsWith(Nine()))
            {
                context.SetOutput(context.GetOutput() + (9 * Multiplier()));
                context.SetInput(context.GetInput().Substring(2));
            }
            //else if (context.GetInput().StartsWith(Four()))
            //{
            //    context.SetOutput(context.GetOutput() + (4 * Multiplier()));
            //    context.SetInput(context.GetInput().Substring(2));
            //}
            else if (context.GetInput().StartsWith(Five()))
            {
                context.SetOutput(context.GetOutput() + (5 * Multiplier()));
                context.SetInput(context.GetInput().Substring(1));
            }
            else if (context.GetInput().StartsWith(Four()))
            {
                context.SetOutput(context.GetOutput() + (4 * Multiplier()));
                context.SetInput(context.GetInput().Substring(2));
            }

            while (context.GetInput().StartsWith(One()))
            {
                context.SetOutput(context.GetOutput() + (1 * Multiplier()));
                context.SetInput(context.GetInput().Substring(1));
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();
    }
}
