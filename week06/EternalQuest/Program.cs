using System;
// Implemented level system where they level up for every 1000 points.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}