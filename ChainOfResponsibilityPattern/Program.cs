using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // As email is received, it is passed to a series of handlers
            // in order : Spam Handler -> Fan Handler -> Complaint Handler
            // -> NewLoc Handler, if the handler can't handle the email, 
            // it will pass on to the next one.

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
