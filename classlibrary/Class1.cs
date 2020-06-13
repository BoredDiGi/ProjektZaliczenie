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

    }
}

