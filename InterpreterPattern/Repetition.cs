namespace InterpreterPattern
{
    public class Repetition : Expression
    {
        private readonly Expression _expression;
        private readonly Variable _variable;

        public override void Interpret(IContext context)
        {
            // Interpret this repetition
        }
    }
}
