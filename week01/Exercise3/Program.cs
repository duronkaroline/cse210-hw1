using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        var scriptures = new List<(string reference, string text)>
    {
         ("Psalm 119:105", "Your word is a lamp to my feet and a light to my path."),
            ("Psalm 23:1", "The Lord is my shepherd; I shall not want."),
            ("Romans 8:28", "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
            ("Romans 12:2", "Do not be conformed to this world, but be transformed by the renewing of your mind, that you may prove what is the good and acceptable and perfect will of God.")    
    
      };

        Random random = new Random();
        var randomScripture = scriptures[random.Next(scriptures.Count)];

       
              Scripture scripture = new Scripture(randomScripture.reference, randomScripture.text);

      
        scripture.DisplayScripture();

        
        while (true)
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
                  string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            
            scripture.HideRandomWord();
            Console.Clear();

            
            scripture.DisplayScripture();

          
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. The scripture is fully memorized!");
                break;
            }
            
        }
    }
    
}

