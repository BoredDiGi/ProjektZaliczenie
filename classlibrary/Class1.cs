using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlibrary
{
    public class lib
    {
        public static bool menu(int m)
        {
            if (m == 1)
            {
                Console.Clear();
                Console.WriteLine("Wybrano grę");
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("kończę działanie, wciśnij dowolny przycisk aby zakończyć");
                Console.ReadLine(); 
                return false;
            }
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

    }
}

