using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int userChoice = -1;

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string randomPrompt = promptGen.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry anEntry = new Entry();
                anEntry._date = dateText;
                anEntry._promptText = randomPrompt;
                anEntry._entryText = response;

                theJournal.AddEntry(anEntry);
            }
            else if (userChoice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
        }
        Console.WriteLine("Goodbye!");
    }
}