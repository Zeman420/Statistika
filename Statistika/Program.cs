using System;

namespace Statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(false);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {

                }
            } while (keyInfo.Key != ConsoleKey.Escape) ;
        }
    }
}
