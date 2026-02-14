using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] splitWords = text.Split(' ');

        for (int i = 0; i < splitWords.Length; i++)
        {
            Word word = new Word(splitWords[i]);
            _words.Add(word);
        }
    }

    public void Display()
    {
        _reference.Display();
        Console.WriteLine();

        for(int i = 0; i < _words.Count; i++)
        {
            _words[i].Display();
            Console.Write(" ");
        }

        Console.WriteLine();
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !AllHidden())
        {
            int index = _random.Next(0, _words.Count);

            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AllHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}