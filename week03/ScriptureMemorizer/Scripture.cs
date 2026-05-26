using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + "\n\n";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        } 
        return display.Trim();
    }
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0)
           return;
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            hiddenCount++;
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
               return false;
        }
        return true;
    }

}