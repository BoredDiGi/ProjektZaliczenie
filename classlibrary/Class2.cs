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
            lib.tester();
            //variables section
            string c = "start"; //menu
            string[] max = System.IO.File.ReadAllLines("../../bestscore.txt"); //best/highscore data
            string[] texts = System.IO.File.ReadAllLines("../../text.txt"); //text data
            var words = new List<string>();
            int newmax = int.Parse(max[0]); //local new variable max
            int ckmax = 0; //local support variable max
            int ckrand = texts.Length + 1; //old max support randomizer
            string[] save = new string[1];
            //end of variables section
            //function initializer
            if (lib.preloader(texts.Length) == true)
            {
                do
                {
                    Console.Clear();
                    Console.Write(" [1] aby grać \n [2] aby zobaczyć ostatnie słowa \n [3] by zobaczyć założenia \n [4] wyzeruj wynik \n [5] wyniki \n [6] wszystkie frazy \n [0] wyłączy grę \n wybieram: ");
                    c = Console.ReadLine(); //menu switch
                    if (c == "0")
                    {
                        break;
                    }
                    else if (c == "2")
                    {
                        Console.Clear();
                        if (words.Count < 1)
                        {
                            Console.WriteLine("brak elementów do wyświetlenia");
                            Console.WriteLine("Kliknij dowolny klawisz aby kontynuować");
                            Console.ReadKey();
                        }
                        else
                        {
                            for (int pp = 0; pp < words.Count; pp++)
                                Console.WriteLine(words[pp]);
                            Console.WriteLine("Kliknij dowolny klawisz aby kontynuować");
                            Console.ReadKey();
                        }
                    }
                    else if (c == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Zagrajmy w grę, najwyższy wynik wynosi: " + newmax + " , a obecny wynik wynosi: " + ckmax);
                        ckrand = lib.randomizer(texts.Length, ckrand); //initialize random engine
                        words.Add(texts[ckrand]);
                        if (gameinitialize.gamechk(texts[ckrand]) == true)
                        {
                            ckmax++;
                            Console.WriteLine("najwyższy wynik: " + newmax + " aktualny wynik: " + ckmax);
                            Console.WriteLine("wciśnij dowolny klawisz aby kontynuować");
                            Console.ReadKey();
                            if (newmax < ckmax)//if true ckmax is newmax
                            {
                                newmax = ckmax;
                                save[0] = newmax.ToString();
                                System.IO.File.WriteAllLines("../../bestscore.txt", save);
                            }
                        }
                        else
                        {
                            Console.WriteLine("koniec szans");
                            Console.WriteLine("kliknij aby kontynuować");
                            Console.ReadKey();
                        }
                    }
                    else if (c == "3")
                    {
                        Console.Clear();
                        gameinitialize.opener();
                        Console.WriteLine("kliknij przycisk aby zaakceptować");
                        Console.ReadKey();
                    }                    
                    else if (c == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("wyzerowano wyniki");
                        ckmax = 0;
                        newmax = 0;
                        save[0] = "0";
                        System.IO.File.WriteAllLines("../../bestscore.txt", save);
                        Console.WriteLine("kliknij aby kontynuować");
                        Console.ReadKey();
                    }
                    else if (c == "5")
                    {
                        Console.Clear();
                        Console.WriteLine("najwyższy wynik: " + newmax + "\naktualny wyniki: "+ ckmax);
                        Console.WriteLine("kliknij przycisk aby zaakceptować");
                        Console.ReadKey();
                    }
                    else if (c == "6")
                    {
                        Console.Clear();
                        lib.allof();
                        Console.WriteLine("kliknij aby kontynuować");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("podano złą wartość");
                        Console.WriteLine("Kliknij dowolny klawisz aby kontynuować");
                        Console.ReadKey();
                    }
                } while (true);
            }
            else
            {
                Console.WriteLine("Za mało danych wejściowych w pliku text.txt, dodaj minimum 3 frazy i uruchom ponownie");
                Console.WriteLine("Kliknij dowolny klawisz aby kontynuować");
                Console.ReadKey();            
            }
            lib.end();
        }
    }
}
