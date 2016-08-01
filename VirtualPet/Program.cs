using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
           string play = "yes";
            int pick;

            StringBuilder huD = new StringBuilder();

            huD.Append("Welcome to the Virtual Pet Program");
            huD.Append('\n' + "Here you can take care of your very own tiger");
            huD.Append('\n' + "His name is Tora");
            huD.Append('\n');
            huD.Append("Would you like to play?  yes/no");
            Console.WriteLine(huD.ToString());                  //calls huD to screen

            play = Console.ReadLine().ToLower();

            VirtualPet Tora = new VirtualPet();

            while (play == "yes")
            {
                //user interface
                StringBuilder screen = new StringBuilder();
                screen.Append('\n' + "What would you like to do?");
                screen.Append('\n' + " 1.Play with Tora");
                screen.Append('\n' + " 2.Feed Tora");
                screen.Append('\n' + " 3.Do nothing");
                screen.Append('\n' + "Enter the number of the action choice");
                Console.WriteLine(screen.ToString());

                pick = int.Parse(Console.ReadLine());              //user chooses one of the options above

                switch (pick)
                {
                    case 1:
                        Tora.playFull(pick);                          
                        break;

                    case 2:
                        Tora.FeedMeSeymour(pick);
                        break;

                    case 3:
                        Tora.sleep();
                        break;

                    default:
                        Tora.Prey();
                        break;
                }

                Tora.tick();

                
                Console.WriteLine('\n' + "Would you like to play some more?  yes/no");
                    play = Console.ReadLine();
            }
        }
    }
}
