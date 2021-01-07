using System;

namespace Textgametest 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables are stated here
            //Player stats are determined by character customisation
            Random generator = new Random();

            int statpoints = 12;
            int playerhp;
            int playerdmg;
            int playerdodge;

            int enemyhp;
            int enemydmg; 
            int enemydodge;

            //Methods are stated here

            void Charcreation()
            {   
                 System.Console.WriteLine("What is your character's name?:");
                 
                 string charname = Console.ReadLine();
                 
                 System.Console.WriteLine(charname + " huh? That's a cool name I guess");
                
                 System.Console.WriteLine("You have " + statpoints + " statpoints\nChoose the stat you would like to improve:");

            }

            void Enemystats()
            {
                
            }

            //Initial info of what the user should do 
            System.Console.WriteLine("Welcome to my text based game!\nFirst, you'll have to create a character\n");

            Charcreation();



            Console.ReadLine();
        }
    }
}