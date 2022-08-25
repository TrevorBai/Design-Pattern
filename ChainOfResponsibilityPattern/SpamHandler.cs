using System;

namespace ChainOfResponsibilityPattern
{
    public class SpamHandler : AbstractHandler
    {
        public override void HandleRequest()
        {
            throw new NotImplementedException();
        }
    }
}
