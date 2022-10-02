using System;

namespace DesignPatterns
{
    internal static class Log
    {
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void ShowMessage(string method, string message)
        {
            Console.WriteLine(string.Format("Method: {0} Message:{1}", method, message));
            Console.WriteLine("---------------------");
        }
    }
}
