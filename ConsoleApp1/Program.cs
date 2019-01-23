using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keypress;
            int r = 0;
            int s1 = 0;
            int s2 = 0;
            DiceBag bag = new DiceBag();
            Console.WriteLine("Press enter to let it roll...");
            while (true) {
                
                keypress = Console.ReadKey();
                if (keypress.Key != ConsoleKey.Enter)
                    break;
                Console.Clear();
                r = bag.Roll(DiceBag.Dice.D100);
                s1 += r;
                Console.Write(r);
                if (r == 100)
                    Console.WriteLine("\t\t\tP1: Saquese alv compa");
                if (r == 1)
                    Console.WriteLine("\t\t\tP2: Pilas compa");
                r = bag.Roll(DiceBag.Dice.D100);
                s2 += r;
                Console.Write("\t" + r + "    \n");
                if (r == 1)
                    Console.WriteLine("\t\t\tP1: Pilas compa");
                if (r == 100)
                    Console.WriteLine("\t\t\tP2: Saquese alv compa");
                Console.Write("__\t__\nP1:"+s1+ "\tP2:"+s2);
                
               
            }

        }

       
    }
}
