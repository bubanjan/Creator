using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to my experimental Console application Creator");
            Thread.Sleep(1);
            Console.WriteLine("Console will paint one apstract painting");
            Console.WriteLine("To stop the process just press left mouse button, to start again press F5 button");
            Thread.Sleep(1);
            Console.WriteLine("Novak Bubanja bubanjanovak@gmail.com");
            Console.WriteLine();

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Random rnd = new Random();
                int numberX = rnd.Next(0, 100);
                
                if (numberX > 10 && numberX < 20)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                else if (numberX > 20 && numberX < 30)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (numberX > 30 && numberX < 40)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (numberX > 40 && numberX < 50)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else if (numberX > 50 && numberX < 60)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (numberX > 60 && numberX < 70)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else if (numberX > 70 && numberX < 80)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (numberX > 80 && numberX < 90)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                else if (numberX > 90 && numberX < 100)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.Write(" ");
                Console.ResetColor();
                
                Console.ResetColor();
                
                Thread.Sleep(1);


            }
        }
    }
}
