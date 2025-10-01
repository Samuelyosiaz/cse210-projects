using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        if (text == null) text = "";

        string[] palabras = text.Split(' ');
        foreach (string palabra in palabras)
        {
            _words.Add(new Word(palabra));
        }

    }

    public void HideRandomWords(int numberToHide)
    {

        var unhidden = _words
            .Select((w, idx) => new { Word = w, Index = idx })
            .Where(x => !x.Word.IsHidden())
            .ToList();

        for (int i = 0; i < numberToHide && unhidden.Count > 0; i++)
        {
            int pick = _random.Next(0, unhidden.Count);
            int idx = unhidden[pick].Index;
            _words[idx].Hide();

            unhidden.RemoveAt(pick);
        }
    }

    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + " " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
    for (int i = 0; i < _words.Count; i++)
    {
        if (!_words[i].IsHidden())
        {
            return false; 
        }
    }
    return true; 

    }
}