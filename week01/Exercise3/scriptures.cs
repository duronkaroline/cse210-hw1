using System;
using System.Collections.Generic;

public class Scripture
{
    private string reference;      private List<Word> words;  

    
    public Scripture (string reference, string text)
    {
                this.reference = reference;
        words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
             Console.ForegroundColor = ConsoleColor.Cyan;
             Console.WriteLine($"\n{reference}");
        Console.ResetColor();

        foreach (Word word in words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }
    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(words.Count);
        words[index].Hide();
    }

   
    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
