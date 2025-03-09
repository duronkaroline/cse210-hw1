using System;

class Program
{
    static void Main(string[] args)
    { List<int> numbers= new List<int>();
    int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.")
        ;
        do {
            Console.Write("Enter your number: ");
            number = int.Parse(Console.ReadLine());

            if (number !=0)
            {
                numbers.Add(number);
            }


        } while(number !=-0);
        int sum1 = numbers.Sum();
        double average1 = numbers.Average();
        int maxnumberr = numbers.Max();

        Console.WriteLine($"The sum is : {sum1}");
        Console.WriteLine($"The average is : {average1}");
        Console.WriteLine($"The largest number is: {maxnumberr}");

    }
}