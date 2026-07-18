using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string fullText = "Trust in the Lord with all thine heart and lean not unto thine own understanding" +
        "In all thy ways acknowledge him and he shall direct thy paths";

        Scripture scripture = new Scripture(reference, fullText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nGoodbye!");
    }
}