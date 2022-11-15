using System;

namespace TestSolution;

class leapyearSolution
{
    public static void Main(String[] args)
    {

        PrintNext20LeapYears();
    }

    private static void PrintNext20LeapYears()

    {
        var year = DateTime.Now.Year;
        var count = 0;
        Console.WriteLine("==== Next leap years ===");
        while (count < 20)
        {
            year += 1;
            if (year % 4 == 0)
            {
                Console.WriteLine("{0}. {1}", count + 1, year);
                count += 1;
            }
        }
    }




}

