using System;

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

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Display()
    {
        if (_isHidden)
        {
            for (int i = 0; i < _text.Length; i++)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(_text);
        }
    }
}
