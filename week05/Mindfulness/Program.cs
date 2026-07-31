using System;
using MindfulnessProgram;
//added feature so it doesn't repeat prompts or questions until they have all been used.
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                    reflection.Run();
                    break;
                case "3":
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("\nGoodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}