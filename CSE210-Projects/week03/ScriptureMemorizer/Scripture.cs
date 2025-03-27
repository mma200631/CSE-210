using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Refrence _reference;
    private List<Word> _words;

    public Scripture(Refrence reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{referenceText}\n{wordsText}";
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        Random random = new Random();
        for (int i = 0; i < Math.Min(count, visibleWords.Count); i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
