using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //where all the virtual pet action happens


        private int hunGer = 10;         //variable representing hunger as int
        private int feels = 10;          //variable representing happiness  as int 
        private int bloodLust = 10;      //variable representing anger  as int

        private int random;          //variable for random number generator
        Random rnd = new Random();






        public void tick()           //tick method updates all attributes and displays on screen
        {
            int hapE = feels;
            int angrE = bloodLust;
            int hungE = hunGer;

            StringBuilder huD = new StringBuilder();
            huD.Append('\n');
            huD.Append('\n' + "      Happiness = " + hapE);                 //display current happiness
            huD.Append('\n' + "      BloodLust = " + angrE);                //display current BloodLust
            huD.Append('\n' + "      Hunger = " + hungE);                   //display current hunger
            Console.WriteLine(huD.ToString());


            
            if (hapE >= 50)                      //if happy attribute greater or equal to 50
            {

                
                hapE = 10;                       //reset happy attribute
                sleep(); 
            }
            else if (angrE >= 50)
            {

                
                angrE = 10;
                Prey();
            }
            else if (hungE >= 50)
            {
                
                hungE = 10;
                Prey();
            }
            else if (hapE <= 30 || angrE <= 30  || hungE <=30)
            { 
                hungE = 10;

                hapE = 10;
                
                angrE = 5;
            }
            


        }

        public void playFull(int choice)     //play method 4 options for user to choose
        {
            
            
            

            StringBuilder duh = new StringBuilder();          //new stringBuilder duh
            duh.Append('\n' + "Tora is interested in playing");
            duh.Append('\n' + "What would you like to do?");
            duh.Append('\n' + " 1.Take him swimming");
            duh.Append('\n' + " 2.Give him a rubber ball");
            duh.Append('\n' + " 3.Rub his head and tummy");
            duh.Append('\n' + " 4.Ignore him");
            duh.Append('\n' + "Enter the number of the action you would like to perform");
            Console.WriteLine(duh.ToString());

            choice = int.Parse(Console.ReadLine());             //user enters choice number

            switch (choice)
            {
                case 1:

                    
                    Console.WriteLine('\n'+"Tora, loves swimming ♥");
                    // begin face plug here duh.Append("");
                    feels += 15;
                    hunGer -= 15;
                    bloodLust -= 15;

                    break;

                case 2:
                    Console.WriteLine('\n' + "Tora is having so much fun!");
                    Console.WriteLine("...so much he forgot you were here");
                    // begin face plug here duh.Append("");
                    feels += 10;
                    hunGer -= 10;
                    bloodLust -= 10;


                    break;

                case 3:
                    Console.WriteLine('\n' + "Tora: ♥♥♥!");
                    // begin face plug here duh.Append("");
                    feels += 5;
                    hunGer -= 5;
                    bloodLust -= 5;

                    break;

                default:
                    Console.WriteLine('\n' + "Tora doesn't like being ignored");
                    // begin face plug here duh.Append("");
                    bloodLust += 15;
                    break;

            }

        }



        public void FeedMeSeymour(int choice)                     //feeding method for virtual pet
        {


            StringBuilder duh = new StringBuilder();              //new stringBuilder duh
            duh.Append("Feeding Time");
            duh.Append('\n' + "What would you like to do?");
            duh.Append('\n' + " 1.Buffalo burger");
            duh.Append('\n' + " 2.Deer stew");
            duh.Append('\n' + " 3.Rabbit surprise");
            duh.Append('\n' + " 4.Enjoy a meal in his face");
            duh.Append('\n' + "Enter the number of the action you would like to perform");
            Console.WriteLine(duh.ToString());



            choice = int.Parse(Console.ReadLine());             //user enters choice number



            switch (choice)                                 //switch statement choice based on user input
            {
                case 1:

                    Console.WriteLine('\n' + "Buffalo burger FTW!");
                    Console.WriteLine("Tora:MHHHMMMM");
                    hunGer += 15;
                    feels += 15;
                    bloodLust -= 15;


                    break;

                case 2:
                    Console.WriteLine('\n' + "Venison, natures chicken ");
                    Console.WriteLine("Tora: MHHHMMMM");
                    hunGer += 10;
                    bloodLust -= 10;
                    feels += 10;


                    break;

                case 3:
                    Console.WriteLine('\n' + "Tora caught a bunny");
                    Console.WriteLine("Oh noos, Ms. bunny has become a widow ");
                    //begin face
                    Console.WriteLine("Tora: MHHHMMMM");
                    hunGer += 5;
                    feels += 5;
                    bloodLust -= 5;

                    break;

                default:
                    Console.WriteLine('\n' + "You're pretty brave to have a meal in front of a tiger without sharing");
                    Console.WriteLine(" Hope he doesnt attack you");
                    //begin face
                    Console.WriteLine("Tora: RAWWWWRRRR!!!");
                    bloodLust += 15;
                    feels -= 10;
                    hunGer += 10;

                    break;
            }
            //tick

        }


        public void Prey()           //called when Tora anger or hunger = 50 
        {

            // Tora hunts when the mood strikes 
            random = rnd.Next(1, 5);                //generate random number 1-6



            for (int i = 0; i < 2; i++)                  //loop that iterates twice
            {
                //random number from 1-3 determine what is being hunted


                Console.WriteLine('\n' + "Tora is currently stalking prey...");

                

                switch (random)
                {
                    case 1:

                        Console.WriteLine('\n' + "Caught a Water Buffalo!");
                        Console.WriteLine("Tora:MHHHMMMM");
                        hunGer += 15;
                        feels += 15;
                        bloodLust -= 15;

                        break;

                    case 2:
                        Console.WriteLine('\n' + "Caught a baby deer");
                        Console.WriteLine("Tora:MHHHMMMM");
                        hunGer += 10;
                        bloodLust -= 10;
                        feels += 10;
                        

                        break;

                    case 3:
                        Console.WriteLine('\n' + "Tora caught a bunny");
                        Console.WriteLine("Oh noos, Ms. bunny has become a widow ");
                        Console.WriteLine("Tora:MHHHMMMM");
                        hunGer += 5;
                        feels += 5;
                        bloodLust -= 5;

                        break;

                    default:
                        Console.WriteLine('\n' + "The prey got away!");
                        Console.WriteLine(" OH well, maybe next time");
                        bloodLust += 10;
                        feels -= 10;
                        hunGer += 10;
                        break;
                }

            }
        }

        public void sleep()                 //when Tora is full he will sleep for 3 turns
        {
            for (int i = 0; i < 2; i++)
            {
                //random number from 1-3 determine what is being hunted


                Console.WriteLine("Tora has decided to take a catnap" + '\n');
                Console.WriteLine("...He wont wake up no matter what you do");

                

                if (bloodLust >= feels)
                { 
                    Console.WriteLine('\n' +"Tora: ZZZZZZZZ");
                        hunGer -= 10;
                        feels += 10;
                        bloodLust -= 10;
                }
                else
                {
                    Console.WriteLine("Oh wait, something woke him up");
                    Console.WriteLine("...And he's back asleep");
                    Console.WriteLine("Tora: ZZZZZZZZ");
                    hunGer -= 5;
                    feels -= 5;
                    bloodLust += 10;
                }

                

            }








        }
    }
}
