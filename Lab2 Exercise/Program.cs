using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "player";


            // Console.WriteLine("Welcome! What is your name?");
            //tring username = Console.ReadLine();
            //UserName();
            string user = UserName();
            Console.WriteLine("\nWould you like to play a game? ( \"yes\" or \"no\") :");
            string playgame = Console.ReadLine();
            
            if( playgame == "yes")
            {
               // Console.Clear();
                Console.WriteLine("Excellent! You are walking across field and you encounter a \nfire-breathing dragon!\nWhat would you do? (\"face the beast\" or \"run away\") ");

                string readreply = Console.ReadLine();
                if (readreply == "face the beast") 
                {
                    Console.WriteLine("\nYou approach the dragon.You see that he has_ heads.(\"1\" or \"2\" or\"3\")");
                    string head = Console.ReadLine();
                    switch(head)
                    {
                        case "1":                           
                        case "2":                            
                        case "3":
                            Console.WriteLine($"No one has ever faced a {head}- headed dragon befor!");
                            Console.WriteLine("Choose your weapon.  \"slingshot\" or \"sword\"or \"bow and arrow\"");

                            string weapon = Console.ReadLine();
                            switch (weapon)
                            {
                                case "slingshot":
                                    Console.WriteLine("Armed with your Slingshot");
                                    break;
                                case "sword":
                                    Console.WriteLine("Armed with your Sword");
                                    break;
                                case "bow and arrow":
                                    Console.WriteLine("Armed with your bow and arrow, you approach the dragon. You can feel it fiery breath as you get closer.\nIt stares at you with its _ eyes.(\"red\" or \"blue\")");

                                    string eye = Console.ReadLine();
                                    switch (eye)
                                    {
                                        case "red":
                                            Console.WriteLine("Oh thank goodness! Red eyed dragons are friendly. You pet it and become friends.\n You name the dragon_______. (Enter a name)");
                                            name = Console.ReadLine();
                                            Console.WriteLine(user + " and " + name + " live happily ever after");
                                            Console.Read();
                                            break;
                                        case "blue":
                                            Console.WriteLine("Oh thank goodness! Blue eyed dragons are dangerous.");

                                            break;


                                    }

                                    break;

                            }
                            break;
                        default:
                            Console.WriteLine("End of the Game");
                            break;


                    }
                   


                }
                else{
                    Console.WriteLine("\nAre you sure you want to run away");
                }
            } 
            else
            {
                Console.WriteLine("\nAre you sure that you don't want to paly");
            }



        }
        static string UserName()
        {
            Console.WriteLine("Welcome! What is your name?");
            string username = Console.ReadLine();
            return username;
        }
    }
}


