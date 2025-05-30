// Represents the book, chapter, and verse(s) of a scripture reference
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // initializes reference info
    public Reference(string book, int chapter, int verseStart, int verseEnd = -1)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    // Returns formatted reference string, e.g. "Proverbs 3:5-6"
    public string GetDisplayText()
    {
        if (_verseEnd == -1)
            return $"{_book} {_chapter}:{_verseStart}";
        else
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}
