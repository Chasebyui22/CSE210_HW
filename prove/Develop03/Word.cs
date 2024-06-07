public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Unhide()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "____" : _text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}
