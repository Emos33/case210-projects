using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new List<Word>();

        // Collect only words that are NOT hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // Stop if no more words to hide
        if (visibleWords.Count == 0)
        {
            return;
        }

        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Count == 0)
            {
                break;
            }

            int index = _random.Next(visibleWords.Count);

            // Hide selected word
            visibleWords[index].Hide();

            // Remove it so it won't be selected again
            visibleWords.RemoveAt(index);
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result;
    }
}