using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool Playagain = true;

        while (Playagain)
        { 
            int magicNumberr =random.Next(1,100);
            int guess = 0;
            int attempts = 0;
            Console.WriteLine("  Pick a number between 1-20");
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            attempts++;
            if (guess < magicNumberr)
            {
                Console.WriteLine("Higher");
            }
            else if (guess> magicNumberr)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine($" you guessed it! your attempts :{attempts} ");
            }
    }
}
}
