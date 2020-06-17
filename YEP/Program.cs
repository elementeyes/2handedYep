using System;
using CharacterBuilder.BuilderTypes;
using CharacterBuilder.State;
using CharacterBuilder.User;

namespace YEP
{
    class Program
    {
        static void Main(string[] args)
        {                  
            char command = ' ';
            Context context = new Context();
            string choice = "";
            while (choice != "f")
            {
                Console.WriteLine(
                    "Please select a character!(esc to stop)" +
                    "\n'd' for Duelist," +
                    "\n'g' for Guardian," +
                    "\n'm' for Marauder," +
                    "\n'w' for Witch,");
                choice = Console.ReadLine();
                if (choice == "" || choice.Length > 1)
                {
                    Console.WriteLine("   Invalid input!");
                }
                else
                {
                    if (choice != null && choice != "" && choice.Length == 1 && choice != "f")
                    {
                        command = choice[0];
                        context.SelectRequest(command);
                        if (choice == "d"|| choice == "g" || choice == "m" || choice == "w")
                        {
                            break;
                        }
                    }

                }
            }
            context.State = new RestingState();            
            Console.WriteLine("\nWelcome to \"The State Game\"!");
            Console.WriteLine("You are standing here looking relaxed!");
            while (command != 'e')
            {
                Console.WriteLine("\nWhat would you like to do now?");
                Console.Write(" Move(m) Attack(a) Stop(s) Run(r) Panic(p) CalmDown(c) Exit(e) the game: ==> ");

                do
                    choice = Console.ReadLine();
                while (choice == null);
                command = choice[0];
                context.Request(command);
            }
        }
    }
}
