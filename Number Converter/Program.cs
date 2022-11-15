using System;

namespace TestSolution;



public class NumberToWordConverter
{
    private static string[] numberInWords =
    {
         "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

    private static string[] multiplesOfTen = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };



    public static string ConvertMethod(int number)
    {
        string conversionResult = default;

        string remainder;

        if (number < 20)
        {

            conversionResult = numberInWords[number];

            return numberInWords[number];

        }

        if (number < 100)
        {
            if (number % 10 != 0)
            {
                remainder = " " + numberInWords[number % 10];

                conversionResult = multiplesOfTen[number / 10] + remainder;

                return conversionResult;

            }

            conversionResult = multiplesOfTen[number / 10];
            return conversionResult;

        }

        if (number < 1000)
        {
            if (number % 100 != 0)
            {
                remainder = " and " + ConvertMethod(number % 100);
                conversionResult = numberInWords[number / 100] + " hundred" + remainder;
                return conversionResult;
            }
            conversionResult = numberInWords[number / 100] + " hundred";
            return conversionResult;

        }
        if (number < 100000)
        {
            if (number % 1000 != 0)
            {
                int[] remainderArr = (number % 1000).ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

                if (remainderArr.Length == 3)
                {
                    remainder = numberInWords[remainderArr[0]] + " hundred and " + multiplesOfTen[remainderArr[1]] + " " + numberInWords[remainderArr[2]];
                    conversionResult = ConvertMethod(number / 1000) + " thousand " + remainder;
                    return conversionResult;
                }
                else if (remainderArr.Length == 2)
                {
                    remainder = " and " + multiplesOfTen[remainderArr[0]] + " " + numberInWords[remainderArr[1]];
                    conversionResult = ConvertMethod(number / 1000) + " thousand " + remainder;
                    return conversionResult;
                }
                else if (remainderArr.Length == 1)
                {
                    remainder = " and " + numberInWords[remainderArr[0]];
                    conversionResult = ConvertMethod(number / 1000) + " thousand " + remainder;
                    return conversionResult;

                }

            }
            conversionResult = ConvertMethod(number / 1000) + " thousand";
            return conversionResult;
        }

        if (number < 1000000)
        {
            int[] digits = (number / 1000).ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            conversionResult = numberInWords[digits[0]] + " hundred and " + multiplesOfTen[digits[1]] + " " + numberInWords[digits[2]] +
                " thousand";

            if (number % 1000 == 0)
            {
                return conversionResult;
            }

            if (number % 1000 != 0)
            {
                int[] remainderArr = (number % 1000).ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
                if (remainderArr.Length == 3)
                {
                    remainder = numberInWords[remainderArr[0]] + " hundred and " + multiplesOfTen[remainderArr[1]] + " " + numberInWords[remainderArr[2]];
                    string resultHere = conversionResult + " " + remainder;
                    return resultHere;
                }
                else if (remainderArr.Length == 2)
                {
                    remainder = " and " + multiplesOfTen[remainderArr[0]] + " " + numberInWords[remainderArr[1]];
                    string resultHere = conversionResult + " " + remainder;
                    return resultHere;
                }
                else if (remainderArr.Length == 1)
                {
                    remainder = " and " + numberInWords[remainderArr[0]];
                    string resultHere = conversionResult + " " + remainder;
                    return resultHere;

                }
            }

        }
        return conversionResult;

    }
}

