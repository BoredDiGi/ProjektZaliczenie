using System;
using classlibrary;

namespace ProjektZaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Title = "Wisielec the game";
            string c = "start"; //menu
            string[] max = System.IO.File.ReadAllLines("../../bestscore.txt"); //best/highscore data
            string[] texts = System.IO.File.ReadAllLines("../../text.txt"); //text data
            int newmax = int.Parse(max[0]); //local new variable max
            int ckmax = 0; //local support variable max
            int ckrand = texts.Length + 1; //old max support randomizer
            string[] test = new string[1]; //support highscore system 
            do
            {
                //Console.Clear();
                Console.Write("wciśnij cokolwiek aby grać, 0 wyłączy grę :) : ");
                c = Console.ReadLine(); //menu switch
                /*if (lib.menu(c) == true) //
                {
                }
                else break; //if someone insert data != 1 program will end*/
                Console.WriteLine("Zagrajmy w grę, najwyższy wynik wynosi: "+ newmax + " , a obecny wynik wynosi: " + ckmax);
                ckrand = lib.randomizer(texts.Length, ckrand); //initialize random engine
                game.gameengine(texts[ckrand]);
                if (lib.highscore(test, newmax, ckmax) == true)
                {
                    newmax = ckmax; //if true ckmax is newmax
                }
            } while (c!="0");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Kończę działanie, dziękuję za grę! Twój najwyższy wynik wyniósł: " + newmax);
            Console.WriteLine("Wciśnij dowolny przycisk aby zakończyć");
            Console.ReadLine();
        }
    }
}
