using System;

namespace Quizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            var sessionConducter = new SessionConductor();

            sessionConducter.Start();
        }
    }
}
