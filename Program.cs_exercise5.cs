using System;

class Program
{
    static void Main(string[] args)
    {
        
    Console.WriteLine("Hello world!");
    string playerN = Askplayer();
    int LuckyN = AskluckyN();
    int powernumber = calculatePowerNumber(LuckyN);
    ShowFinalResult(playerN,powernumber);
}

static void showWelcomeMessage()
{
    Console.WriteLine("welcome to the power calculator! ");
    }

    static string Askplayer()

    {
        Console.Write("What's your name, adventure?");
        return Console.ReadLine();
    }


    static int AskluckyN()

    {
        Console.Write("What's your lucky number?");
        return int.Parse(Console.ReadLine());
    }
    static int calculatePowerNumber(int number)
    {
        

        return number * number;
    }

    static void ShowFinalResult(string playerN, int powernumber)
    {
        Console.WriteLine($" {playerN}, your power number is {powernumber} , your doing great " );
    }

}
