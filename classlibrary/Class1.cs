using System;

namespace classlibrary
{
    public class lib
    {
        public static int randomizer(int len, int ck)
        {
            int a;
            do
            {
                Random rnd = new Random();
                a = rnd.Next(len - 1);
            } while (a == ck);
            return a;
        }  
        public static bool highscore(string[] max, int newmax, int cmax)
        {
            if (cmax > newmax)
            {
                max[0] = cmax.ToString();
                System.IO.File.WriteAllLines("../../bestscore.txt", max);
                Console.WriteLine("najlepszy wynik pobity");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool end()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Kończę działanie, dziękuję za grę!");
            Console.WriteLine("Wciśnij dowolny przycisk aby zakończyć");
            Console.ReadKey();
            return true;
        }
    }
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
      
        public static bool gamechk(string texts)
        {
            gameinitialize.gameprinter(texts);
            for (int a = 0; a < texts.Length; a++)
            {
                string comp = Console.ReadLine();
                Console.WriteLine(texts[a]);
                Console.WriteLine(comp);
                for (int b = 0; b < texts.Length; b++)
                {
                    if (string.Equals(comp[0], texts[b]) == true)
                    {
                        return true;
                    }
                }
            }
        return false;                  
        }
    }

}

