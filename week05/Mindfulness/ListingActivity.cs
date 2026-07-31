using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths",
            "Who are people that you have helped this week?",
            "When have you felt peace or inspiration this month?",
            "Who are some of your personal heroes?"
        };

        private List<string> _unusedPrompts;
        private Random _random = new Random();

        public ListingActivity() : base(
            "Listing Activity",

            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            ResetPrompts();
        }

        private void ResetPrompts() => _unusedPrompts = new List<string>(_prompts);

        private string GetRandomPrompt()
        {
            if (_unusedPrompts.Count == 0) ResetPrompts();
            int index = _random.Next(_unusedPrompts.Count);
            string prompt = _unusedPrompts[index];
            _unusedPrompts.RemoveAt(index);
            return prompt;
        }

        public override void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("List as many items as you can according to the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt} ---");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.WriteLine();

            int itemCount = 0;
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");

                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    itemCount++;
                }
            }

            Console.WriteLine($"You listed {itemCount} items!");
            DisplayEndingMessage();
        }
    }
}