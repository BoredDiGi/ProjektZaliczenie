using System;

namespace classlibrary
{
    public class gameinitialize
    {
        public static int gameprinter(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("wylosowany wyraz ma: "+text.Length+" liter");
            for(int counter = 0; counter < text.Length; counter++)
            {
                Console.Write(" _ ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            return 0;
        }
    }
}

