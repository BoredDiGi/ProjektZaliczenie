using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlibrary
{
    public class gameall
    {
        public static void gamemode()
        {
            Console.Title = "Wisielec the game";
            //variables section
            string c = "start"; //menu
            string[] max = System.IO.File.ReadAllLines("../../bestscore.txt"); //best/highscore data
            string[] texts = System.IO.File.ReadAllLines("../../text.txt"); //text data
            int newmax = int.Parse(max[0]); //local new variable max
            int ckmax = 0; //local support variable max
            int ckrand = texts.Length + 1; //old max support randomizer
            string[] test = new string[1]; //support highscore system 
            //end of variables section
            //function initializer
            do
            {
                //Console.Clear();*
                Console.Write("wciśnij cokolwiek aby grać, 0 wyłączy grę :) : ");
                c = Console.ReadLine(); //menu switch
                Console.WriteLine("Zagrajmy w grę, najwyższy wynik wynosi: " + newmax + " , a obecny wynik wynosi: " + ckmax);
                ckrand = lib.randomizer(texts.Length, ckrand); //initialize random engine
                //gameinitialize.gameprinter(texts[ckrand]);
                if (gameinitialize.gamechk(texts[ckrand]) == true)
                {
                    ckmax++;
                    Console.WriteLine(newmax);
                    newmax = ckmax; //if true ckmax is newmax
                }
            } while (c != "0");
            
            lib.end();
        }
    }
}
