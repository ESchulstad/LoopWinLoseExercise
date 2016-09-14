using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWinLoseExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer.");
            int num = int.Parse(Console.ReadLine());

            do
            {
                if (num % 3 == 0)
                {
                    break;
                }
                Console.WriteLine("You Lost.");
                Console.WriteLine("Please enter another integer.");
                num = int.Parse(Console.ReadLine());

            } while (true);

            Console.WriteLine("You Won!");

        }
    }
}
