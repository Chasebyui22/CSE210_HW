public class Entry {
    public string _givenPrompt = "";
    public string _entryText = "";
    public string _entryDateTime = "";
    public string _entrymood = "";
    public Entry(string givenPrompt, string entryText, string entryDateTime, string entrymood) {
        _givenPrompt = givenPrompt;
        _entryText = entryText;
        _entryDateTime = entryDateTime;
        _entrymood = entrymood;
    }   

    public void Display()
    {
        Console.WriteLine("Date: " + _entryDateTime);
        Console.WriteLine("Mood: " + _entrymood);
        Console.WriteLine("Prompt: " + _givenPrompt);
        Console.WriteLine("Entry: " + _entryText);
        Console.WriteLine();
    }
}