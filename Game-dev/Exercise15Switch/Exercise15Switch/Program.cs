using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15Switch
{
    /// <summary>
    /// This is exactly like exercise 15 but with switch statments
    /// </summary>
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

            switch (answer)
            {
                case 1:
                    Console.WriteLine("Staring New game...");
                    break;

                case 2:
                    Console.WriteLine("Loading game...");
                    break;

                case 3:
                    Console.WriteLine("Options loading..");
                    break;

                case 4:
                    Console.WriteLine("Quiting game");
                    break;

                default:
                    Console.WriteLine("You must choose from the given options!");
                    break;

            }
        }
    }
}
