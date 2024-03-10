using System;
using System.Text;

namespace dumpsterdiver
{
    class versionOne
    {
        static void Main(string[] args)
        {
            int gadgets = 0, trash = 0, round = 0, direction = 0;
            Random r = new Random();
            bool win = false;
            Console.Write("What is your goal in this adventure? ");
            string goal = Console.ReadLine();
            while (gadgets > 0 && trash > 0 && win == false)


            {
                direction = chooseDirection();
                if (direction == 1)

                    actions(r.Next(4), ref gadgets, ref trash);

                else
                    actions(r.Next(7), ref gadgets, ref trash);
                checkResults(ref round, ref gadgets, ref trash, ref win);
            }
            if (win)
                Console.WriteLine("Congratulations on successfully picked up tons of bottles");
            else if (trash >= 10)
                Console.WriteLine("You picked up to much trash and your bag if full. You gained nothing.");
            else
                Console.WriteLine("You got tired passed out on the ground.");

        }

        private static void checkResults(ref int round, ref int gadgets, ref int trash, ref bool win)
        {
            round++;

            Console.Write("Round" + gadgets);
            Console.Write("Trash:" + trash);

            if (round >= 8)
            {
                win = true;
            }
            else
            {
                win = false;
            }
        }

        private static void actions(int num, ref int gadgets, ref int trash)
        {
            switch (num)
            {
                case 0:
                    Console.WriteLine("You feel what seems to be some wire and it turns out it was a computer part");
                    Console.WriteLine("You gained +1 gadget.");
                    gadgets += 1;
                    break;
                case 1:
                    Console.WriteLine("You find a bag of watch parts along with trash inside.");
                    Console.WriteLine("You gained +2 gagets but also +2 things of trash.");
                    gadgets -= 2;
                    trash -= 2;
                    break;
                case 2:
                    Console.WriteLine("You find a somewhat decent motherboard of some kind with some tape wrapped around it ");
                    Console.WriteLine("You gained +1 gadget but also +1 thing of trash");
                    gadgets += 1;
                    trash += 1;
                    break;

                case 3:
                    Console.WriteLine("You come across another cleaned dumpster and decided to throw some trash that you had collected.");
                    Console.WriteLine("You lost -3 things of trash");
                    trash -= 3;
                    break;

                case 4:
                    Console.WriteLine("You picked up what seemd like a bag of part but it was instead lots of trash.");
                    Console.WriteLine("You gained +2 things of trash");
                    trash += 2;
                    break;

                case 5:
                    Console.WriteLine("YOu find an unscaved box of random good condition gadget parts");
                    Console.WriteLine("You gained +4 gadgets");
                    gadgets += 4;
                    break;
                case 6:
                    Console.WriteLine("You dumped off some trashed and found some iphone parts in doing so");
                    Console.WriteLine("You gained +2 gadgets and lost -2 trash.");
                    gadgets -= 2;
                    trash += 2;
                    break;

                default:
                    Console.WriteLine("You find a watch with only a cracked case");
                    Console.WriteLine("You gained +1 gadget.");
                    gadgets += 1;
                    break;
            }
        }

        private static int chooseDirection()
        {
            int direction;
            Console.WriteLine("Will you pick trash up by the river side (1) or on the beach (2)?");
            direction = int.Parse(Console.ReadLine());

            while (direction != 1 && direction != 2)
            {
                Console.WriteLine("You entered an invalid number, please enter a 1 for river side or a 2 beach.");
                direction = int.Parse(Console.ReadLine());
            }
            return direction;
        }

    }
}
