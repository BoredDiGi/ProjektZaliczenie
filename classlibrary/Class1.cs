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
        //old highscore function, not in use
        /*public static bool highscore(string[] max, int newmax, int cmax)
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
        }*/
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
            int counterletter = 0;
            int test;
            gameinitialize.gameprinter(texts);
            for (int a = 0; a < texts.Length; a++)
            {
                test = texts.Length - a;
                Console.WriteLine("masz jeszcze " + test + " szans na podanie litery");
                string comp = Console.ReadLine().ToUpper();              
                for (int b = 0; b < texts.Length; b++)
                {
                    if (string.Equals(comp[0], texts[b]) == true)
                    {
                        counterletter+=1;
                        Console.WriteLine("poprawna litera, ilość poprawnych liter:" + counterletter);
                    }
                    if (counterletter >= texts.Length)
                    {
                        Console.WriteLine("gratulacje, zdobyłeś/aś punkt!");
                        return true;
                    }
                }
            }
            Console.WriteLine("niestety, nie udało się, spróbuj jeszcze raz!");
            Console.WriteLine("Wciśnij dowolny klawisz aby kontynuować");
            Console.ReadKey();
        return false;                  
        }

        public static string opener()
        {
            Console.WriteLine("witaj w mojej grze");
            Console.WriteLine("Wisielec TheGame to gra komputerowa stworzona jako projekt na zaliczenie podstaw programowania");
            Console.WriteLine("jej zasady są bardzo łatwe, przyjmujemy że masz tyle szans na podanie litery, ile jest liter w wyrazie");
            Console.WriteLine("gdy podasz wszystkie poprawne litery, dostajesz 1 punkt");
            Console.WriteLine("jeśli nie podasz wszystkich właściwych liter, nie dostajesz punktu");
            Console.WriteLine("życzę miłej gry!");
            return "z";
        }
    }

}

