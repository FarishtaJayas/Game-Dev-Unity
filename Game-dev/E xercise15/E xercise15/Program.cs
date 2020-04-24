using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_xercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1-NewGame");
            Console.WriteLine("2-LoadGame");
            Console.WriteLine("3-Options");
            Console.WriteLine("4-Quit");
            Console.WriteLine("************");

            int answer = int.Parse(Console.ReadLine());
            
            if(answer == 1 )
            {
                Console.WriteLine("Starting new game..");
            }

            else if (answer == 2 )
            {
                Console.WriteLine("Loading game....");
            }

            else if (answer == 3)
            {
                Console.WriteLine("1: Keyboard Settings");
                Console.WriteLine("2: Mouse Settings");
            }

            else if(answer == 4)
            {
                Console.WriteLine("Quitting game");
            }

            else
            {
                Console.WriteLine("Plese select from the given options");
            }

        }
    }
}
