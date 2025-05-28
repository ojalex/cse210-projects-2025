// Represents a single word in the scripture
public class Word
{
    private string _text;
    private bool _hidden;

    // Constructor sets the word text and initializes as visible
    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    // Returns the word text or underscores if hidden
    public string GetDisplayText()
    {
        if (_hidden)
            return new string('_', _text.Length);
        else
            return _text;
    }

    // Marks this word as hidden
    public void Hide()
    {
        _hidden = true;
    }

    // Returns true if the word is hidden
    public bool IsHidden()
    {
        return _hidden;
    }
}
