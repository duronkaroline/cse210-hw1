   static void Main(string[] args)
    {
        {
         journal myJournal = new Journal();
          bool running = true;
    


    while (running)

    { Console.WriteLine("Journal Menu:");
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
        myJournal.WriteNewENTRY();
        break;
        case "2":
        myJournal.WriteNewENTRY();
        break;
        case "3":
        myJournal.WriteNewENTRY();
        break;
        case "4":
        myJournal.WriteNewENTRY();
        break;
        case "5":
        myJournal.WriteNewENTRY();
        break;

      default:
        Console.WriteLine("Invalid option, please try again.\n");
        break;
