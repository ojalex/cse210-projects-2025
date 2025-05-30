using System;
using System.Collections.Generic;
using System.Linq;

// Manages the scripture text and reference
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
   
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

 
    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return _reference.GetDisplayText() + " " + wordsText;
    }


    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); 
        }
    }


    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
