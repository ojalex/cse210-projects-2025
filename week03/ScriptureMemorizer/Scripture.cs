using System;
using System.Collections.Generic;
using System.Linq;

// Manages the scripture text and reference, including hiding words
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor takes a Reference and the scripture text string
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Split text into words and create Word objects
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // Returns the full scripture with reference and words (hidden or shown)
    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return _reference.GetDisplayText() + " " + wordsText;
    }

    // Hides a specified number of random visible words
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove to avoid hiding the same word twice
        }
    }

    // Checks if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
