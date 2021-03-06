﻿using System;
using System.Collections.Generic;

namespace classlibrary
{
    public class lib
    {
        public static bool preloader(int lengthof)
        {
            Console.Title = "Wisielec the game";
            Console.WindowHeight = 14;
            Console.WindowWidth = 70;
            if (lengthof > 2)
                return true;
            else
                return false;
        }
        public static bool tester()//sprawdzanie czy pliki są na swoich miejscach
        {        
            try
            {
                string[] test1 = System.IO.File.ReadAllLines("../../bestscore.txt"); //best/highscore data
                string[] test2 = System.IO.File.ReadAllLines("../../text.txt"); //text data
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Brak wymaganych plików, upewnij się czy pliki: \n bestscore.txt \n text.txt \n są na odpowiednich miejscach \n następnie uruchom ponownie");
                Console.ReadKey();
                end();
            }
            return false;
        }
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
            Environment.Exit(0);
            return true;
        }
        public static bool allof()
        {
            string[] texts = System.IO.File.ReadAllLines("../../text.txt"); //text data
            for(int i = 0; i < texts.Length; i++)
                Console.WriteLine(texts[i]);
            return true;
        }
    }
    public class gameinitialize
    {
        public static bool gamechk(string textsold)//letter check
        {
            string texts = textsold.ToLower();
            var letters = new List<char>();
            var letter = new List<char>();
            letter.Add(',');
            letter.Add('.');
            letter.Add(' ');
            letter.Add('-');
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
                else if(texts[a] == '.')
                {
                    letters.Add('.');
                    points++;
                }
                else if (texts[a] == ',')
                {
                    letters.Add(',');
                    points++;
                }
                else if (texts[a] == '-')
                {
                    letters.Add('-');
                    points++;
                }
                else
                    letters.Add('_');
            }
            lll = points;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int c = 0; c < letters.Count; c++)//wypisywanie frazy
            {
                Console.Write(letters[c]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            for (int b = 1; b > 0; b++)//główna funkcja programu
            {
                nowsupp = 0;
                Console.WriteLine("Pozostało prób: " + now);
                checker = 0;
                do //autorskie sprawdzanie czy podano tylko 1 znak
                {
                    Console.WriteLine();
                    Console.WriteLine("podaj jedną literę, gdy podasz więcej program poprosi jeszcze raz \n 'quit' aby wyzerować szanse i wyjść ");
                    lettest = Console.ReadLine().ToString().ToLower();
                    y = lettest.Length;
                    if (lettest.Equals("quit")==true)
                        return false;
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
                    Console.WriteLine("podano tę samą literę, lub znak interpunkcyjny");
                }
                else
                {
                    letter.Add(let); //dodawanie litery do listy już użytych liter
                    Console.WriteLine("masz " + points + " liter (ze znakami interpunkcyjnymi), \n z " + (texts.Length - 1) + " wymaganych do ukończenia");
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
                Console.ForegroundColor = ConsoleColor.Green;
                for (int c = 0; c < letters.Count; c++)//wypisywanie frazy
                {
                    Console.Write(letters[c]);
                }
                Console.ForegroundColor = ConsoleColor.White;
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
            Console.WriteLine("jej zasady są bardzo łatwe, 10 razy możesz podać błędną literę");
            Console.WriteLine("gdy podasz wszystkie poprawne litery, dostajesz 1 punkt");
            Console.WriteLine("jeśli nie podasz wszystkich właściwych liter, nie dostajesz punktu");
            Console.WriteLine("życzę miłej gry!");
            return "z";
        }
    }
}

