public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<Word> _hiddenWords;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _hiddenWords = new List<Word>();
        _random = new Random();
    }

    public void HideWords()
    {
        var nonHiddenWords = _words.Where(word => !word.IsHidden()).ToList();
        int wordsToHide = _random.Next(1, Math.Max(1, nonHiddenWords.Count / 2));

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(nonHiddenWords.Count);
            nonHiddenWords[index].Hide();
            nonHiddenWords.RemoveAt(index);
        }
    }

    public void Display()
    {
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine();
        }
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
    
    public void ResetHiddenWords()
    {
        foreach (var word in _words)
        {
            word.Unhide();
        }
        _hiddenWords.Clear();
    }
}
