using System;
using System.Collections.Generic;

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
        /*public static int gameprinter(string text)
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
            
        }*/

        /*public static bool gamechk(string texts)//letter check
        {
            int counterletter = 0;
            int test;
            int checker;
            var letters = new List<string>();
            gameinitialize.gameprinter(texts);
            for (int a = 0; a < texts.Length; a++)
            {
                checker = 0;
                test = texts.Length - a;
                Console.WriteLine("masz jeszcze " + test + " szans na podanie litery");
                string comp = Console.ReadLine().ToUpper();
                letters.Add(comp);              
                for (int b = 0; b < texts.Length; b++)
                {

                    for (int c = 0; c == letters.Count; c++)
                    {
                        Console.WriteLine(letters[c]);
                        if (string.Equals(comp[0], letters[c]) == false)
                        {
                            Console.WriteLine("podano drugi raz tą samą literę");
                            a--;
                            checker = 1;
                        }
                    }

                    if (string.Equals(comp[0], texts[b]) == true && checker != 1)
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
        }*/
        public static bool gamechk(string texts)//letter check
        {
            var letters = new List<char>();
            var letter = new List<char>();
            char let;
            int y;
            string lettest;
            int checker;
            int points = 0;
            for (int a = 0; a < texts.Length; a++)
            {
                if (texts[a] == ' ')
                {
                    letters.Add(' ');
                    points++;
                }
                else
                    letters.Add('_');
            }
            
            for (int b = 0; b < texts.Length; b++)
            {
                
                checker = 0;
                for (int c = 0; c < letters.Count; c++)
                {
                    Console.Write(letters[c]);
                }
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("podaj jedną literę, gdy podasz więcej program poprosi jeszcze raz");
                    lettest = Console.ReadLine().ToString().ToUpper();
                    y = lettest.Length;
                } while (y != 1);

                let = char.Parse(lettest);      
                
                for(int d = 0; d < letter.Count; d++)
                {
                    if(letter[d].Equals(let) == true)
                    checker++;
                }
                if (checker != 0)
                {
                    Console.WriteLine("podano tę samą literę");
                }
                else
                {
                    letter.Add(let);
                    Console.WriteLine("masz " + points + "liter, z " + texts.Length + " wymaganych do ukończenia");
                    for (int e = 0; e < texts.Length; e++)
                    {
                        
                        if (texts[e].Equals(let) == true)
                        {
                            letters[e] = let;
                            points++;
                        }
                        if(points == texts.Length)
                        {
                            Console.WriteLine("gratulację! Zdobyto punkt!");
                            return true;
                        }
                    }
                }
            }


            Console.ReadKey();
            return false;
        }
            public static string opener() //information function
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

