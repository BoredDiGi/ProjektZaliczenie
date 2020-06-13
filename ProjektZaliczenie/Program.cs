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
        {
            Console.Title = "gra logiczna";
            do
            {
                Console.Write("wciśnij 1 aby grać, każda inna cyfra wyłączy grę :) : ");
                int c = int.Parse(Console.ReadLine());
                if (lib.menu(c) == true)
                {
                }
                else
                {
                    break;
                }
                Console.WriteLine("Zagrajmy w grę...");
                
            } while (true);         
        }

    }
}
