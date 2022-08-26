namespace InterpreterPattern
{
    public class Sequence : Expression
    {
        private readonly Expression _expression1;
        private readonly Expression _expression2;

        public override void Interpret(IContext context)
        {
            // Interpret this sequence
        }
    }
}
