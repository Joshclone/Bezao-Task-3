using System;

namespace PigLatinTranalator
{
    class Program
    {
        /*
        PigLatin Translator Rules:
        1. If a word starts with a vowel add the word "way" at the end of the word.
        Example: Awesome = Awesome +way = Awesomeway
       
        2. If a word starts with a consonant and a vowel, put the first letter of the word at the end of the word and add "ay."
        Example: Happy = appyh + ay = appyhay
       
        3. If a word starts with two consonants move the two consonants to the end of the word and add "ay."
        Example: Child = ildch + ay = ildchay
        
        */

        static void Main(string[] args)
        {

            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine();

            Console.Write("Enter word: ");
            string Word = Console.ReadLine();

            //Logic 
            // We are assuming that every word has a vowel
            // We are assuming that every word has a vowel as the 1st, 2nd or 3rd letter

            //- Step1 find the vowel
            //- Step2 follow a rule


            // Step 1

            int VowelPostion = -1;
            foreach (char letter in Word)
            {
                VowelPostion = VowelPostion + 1;
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    break;
                }

            }

            //Step 2

            string PigLatinWord = "";
            string BeforeLetters = "";
            string AfterLetters = "";

            switch (VowelPostion)
            {
                case 0:
                    //rule 1 - add "way" 

                    PigLatinWord = Word + "way";
                    break;

                case 1:
                    //rule 2- first letter at end + "ay";

                    BeforeLetters = Word.Substring(0, 1);
                    AfterLetters = Word.Substring(1);
                    PigLatinWord = AfterLetters + BeforeLetters + "ay";
                    break;

                case 2:
                    //rule 3 - 2 consonants add to end + "ay"

                    BeforeLetters = Word.Substring(0, 2);
                    AfterLetters = Word.Substring(2);
                    PigLatinWord = AfterLetters + BeforeLetters + "ay";
                    break;


                default:
                    PigLatinWord = "Unable to translate";
                    break;
            }

            Console.WriteLine("Translation: " + PigLatinWord);
            Console.WriteLine();

            Console.WriteLine("--- Press any key to exist ---");

            Console.ReadKey();

        }
    }
}

