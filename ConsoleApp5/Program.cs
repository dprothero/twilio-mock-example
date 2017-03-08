using System;
using ClassLibrary1;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new SmsService();
            var msg = service.SendMessage("+12095551212", "yo");

            Console.WriteLine(msg.Sid);
            Console.ReadKey();
        }
    }
}
