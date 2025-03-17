 using System;

class Program
{
    static void Main(string[] args)
    {
         MyyJournal  myJournal = new MyyJournal();
          bool running = true;
    


    while (running)

    {   
      Console.WriteLine(" Welcome to My Deep Journal, Please select one option:");
       Console.WriteLine("Journal Menu:");
       Console.WriteLine("1.Write a new entry");
       Console.WriteLine("2.Display journal");
       Console.WriteLine("3. Save journal to a file");
       Console.WriteLine("4. Load journal from a file ");
       Console.WriteLine("5. Exit");
       Console.Write("Choose an option: ");

       String choice = Console.ReadLine();
       Console.WriteLine();

       switch (choice)
       {
        case "1":
            
             myJournal.WriteEntry();
            break;
        case "2":
            myJournal.DisplayJournal();
            break;
        case "3":
            Console.Write("enter filename to save");
            string savefile = Console.ReadLine();
             myJournal.SaveJournal(savefile);
            break;
        case "4":
            Console.Write("enter filename to load");
            string loadfile = Console.ReadLine();
            myJournal.LoadJournal(loadfile);
            break;
        case "5":
            running = false;
            Console.WriteLine("Existing Journal App...");
            break;

      default:
            Console.WriteLine("Invalid option, please try again.");
        break;

       }


    }

    }
    }
    
