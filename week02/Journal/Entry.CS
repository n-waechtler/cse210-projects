public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} - Mood: {_mood}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}