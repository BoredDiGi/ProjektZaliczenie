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
        public static bool gamechk(string texts)//letter check
        {
            var letters = new List<char>();
            var letter = new List<char>();
            char let;
            int y;
            string lettest;
            int checker;
            int points = 0;
            int lll = 0;
            int now = 10;
            int nowsupp = 0;
            for (int a = 0; a < texts.Length; a++) //dodawanie ' ' lub '_' w zależności od znaku
            {
                if (texts[a] == ' ')
                {
                    letters.Add(' ');
                    points++;
                }
                else
                    letters.Add('_');
            }
            lll = points;
            for (int c = 0; c < letters.Count; c++)//wypisywanie frazy
            {
                Console.Write(letters[c]);
            }
            Console.WriteLine();
            for (int b = 1; b > 0; b++)//główna funkcja programu
            {
                nowsupp = 0;
                Console.WriteLine("Pozostało prób: " + now);
                checker = 0;
                do //autorskie sprawdzanie czy podano tylko 1 znak
                {
                    Console.WriteLine();
                    Console.WriteLine("podaj jedną literę, gdy podasz więcej program poprosi jeszcze raz");
                    lettest = Console.ReadLine().ToString().ToUpper();
                    y = lettest.Length;
                } while (y != 1);

                let = char.Parse(lettest);
                Console.Clear();
                for(int d = 0; d < letter.Count; d++)//sprawdzanie powtórzenia litery
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
                    letter.Add(let); //dodawanie litery do listy już użytych liter
                    Console.WriteLine("masz " + points + "liter, z " + (texts.Length - 1) + " wymaganych do ukończenia");
                    for (int e = 0; e < texts.Length; e++) //sprawdzanie czy podana litera znajduje się w wyrazie
                    { 
                        if (texts[e].Equals(let) == true)
                        {
                            letters[e] = let;
                            points++;
                            nowsupp++;
                        }
                    }
                    if(nowsupp == 0)
                    {
                        now--;
                    }
                    if(now == 0)
                    {
                        return false;
                    }

                }
                for (int c = 0; c < letters.Count; c++)//wypisywanie frazy
                {
                    Console.Write(letters[c]);
                }
                Console.WriteLine();
                if(points == texts.Length)//sprawdzanie czy osiągnięto zwycięstwo
                {
                    Console.WriteLine("gratulację! Zdobyto punkt!");
                    return true;
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

