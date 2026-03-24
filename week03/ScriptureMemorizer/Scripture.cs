using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + " " + text;
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
}