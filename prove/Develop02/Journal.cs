public class Journal() {
    public List<Entry> entries = new List<Entry>();
    FileHandler fileHandler = new FileHandler();
    public void addEntry() {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.WriteLine("On a scale from 1 to 10. How would you rank today?");
        string mood = Console.ReadLine();
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.Generate();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response, DateTime.Now.ToString(), mood));
    }
    public void SaveJournal(string filename) {
        fileHandler.SaveEntry(entries, filename);
    }
    public void LoadJournal(string filename) {
        entries = fileHandler.LoadEntries(filename);
    }
    public void displayEntries() {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }
}