using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classlibrary;

namespace ProjektZaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Title = "Wisielec the game";
            int c = 0;
            string[] max = System.IO.File.ReadAllLines("../../bestscore.txt");
            string[] texts = System.IO.File.ReadAllLines("../../text.txt");
            Console.WriteLine(texts[0]);
            int newmax = int.Parse(max[0]);
            int ckmax = 0;
            int ckrand = texts.Length + 1;
            do
            {
                //Console.Clear();
                Console.Write("wciśnij 1 aby grać, każda inna cyfra wyłączy grę :) : ");
                c = int.Parse(Console.ReadLine());
                if (lib.menu(c) == true)
                {
                    ckmax++;
                }
                else
                {
                    break;
                }
                Console.WriteLine("Zagrajmy w grę, najwyższy wynik wynosi: "+ newmax + " , a obecny wynik wynosi: " + ckmax);
                ckrand = lib.randomizer(texts.Length, ckrand);
                Console.WriteLine("wylosowano wyraz: " + texts[ckrand]);
                if (ckmax > newmax)
                {
                    newmax = ckmax;
                    max[0] = ckmax.ToString();
                    System.IO.File.WriteAllLines("../../bestscore.txt", max);
                }
            } while (true);         
        }

    }
}
