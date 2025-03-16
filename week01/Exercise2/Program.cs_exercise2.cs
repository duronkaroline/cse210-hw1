using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage:");
        int grade = int.parse(console.ReadLine());
        string letter1 = "";
        string sign = "";

        if (grade >= 90)
        {
            letter1 = "A"
        }
        else if (grade >= 80)
        {
            letter1 ="B";
        }
        else if (grade >= 70)
        {
            letter1 ="c";
        }
else if (grade >= 60)
        {
            letter1 ="D";
        }

    else {
        letter1 = "F";
    }

if(grade >=70)
{Console.Writeline("Congratulations you passed")}

    }
    else 

{Console.Writeline("Keep trying")}

}