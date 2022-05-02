using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{





    //private static void PrintMessages(int numberOne, int numberTwo, int expected, int multiply, bool isTwentyFive)
    //{
    //    Console.WriteLine($"The expected value is: {expected}");
    //    Console.WriteLine($"{numberOne} * {numberTwo} = {multiply}");

    //    if (isTwentyFive == true)
    //    {
    //        Console.WriteLine($"The Number: {multiply} Matched the expected value");

    //    }
    //    else if (isTwentyFive == false)
    //    {
    //        Console.WriteLine($"The Number: {multiply} Does Not Match the expected value");

    //    }


        //Write a function to format a phone number from a string of 11 digits.
        //The function should take 2 parameters an enum with the options(Dashes or Parentheses) and a string as parameters.
        //Format the string based off the enum value.
        //The return format should be #-###-###-#### or +#(###)###-####.
        //Return the string if the number doesn't start with 1 or is not 11 characters long.
        //Print the output to the console window.





        //    internal class Program
        //    {
        //        private enum NumberFormat
        //        {
        //            Dashes,
        //            Parentheses
        //        }

        //        private static void Main(string[] args)
        //        {
        //            string phoneNumber = "10123456789";
        //            string phoneNumberWithDases = FormatPhoneNumber(NumberFormat.Dashes, phoneNumber);
        //            Console.WriteLine($"Phone Number With Dashes: {phoneNumberWithDases}");
        //            string phoneNumberWithParenthesis = FormatPhoneNumber(NumberFormat.Parentheses, phoneNumber);
        //            Console.WriteLine($"Phone Number With Parenthesis {phoneNumberWithParenthesis}");

        //            string shortPhoneNumber = FormatPhoneNumber(NumberFormat.Parentheses, "12344444");

        //            Console.WriteLine($"Short phone number : {shortPhoneNumber}");

        //            string internationalNumber = FormatPhoneNumber(NumberFormat.Parentheses, "886466423221");

        //            Console.WriteLine($"International number with dashes : {internationalNumber}");


        //        }
        //        private static string FormatPhoneNumber(NumberFormat numberFormat, string phoneNumber)
        //        {
        //            if (!phoneNumber.StartsWith('1') || phoneNumber.Length != 11)
        //            {
        //                return phoneNumber;
        //            }

        //            string formattedPhoneNumber = "";
        //            int counter = 0;

        //            if (numberFormat == NumberFormat.Dashes)
        //            {
        //                foreach (char c in phoneNumber)
        //                {
        //                    if (counter == 1 || counter == 4 || counter == 7)
        //                    {
        //                        formattedPhoneNumber += "-";
        //                    }
        //                    formattedPhoneNumber += c.ToString();
        //                    counter++;

        //                }
        //            }
        //            if (numberFormat == NumberFormat.Parentheses)
        //            {
        //                foreach (char c in phoneNumber)
        //                {
        //                    if (counter == 0)
        //                    {
        //                        formattedPhoneNumber += "+";

        //                    }
        //                    if (counter == 1)
        //                    {
        //                        formattedPhoneNumber += "(";

        //                    }
        //                    if (counter == 4)
        //                    {
        //                        formattedPhoneNumber += ")";
        //                    }
        //                    if (counter == 7)
        //                    {
        //                        formattedPhoneNumber += "-";
        //                    }

        //                    formattedPhoneNumber += c.ToString();

        //                    counter++;
        //                }

        //            }
        //            return formattedPhoneNumber;
        //        }

        //    }
        //}


        //    using System;

        //    namespace ConsoleApp
        //    {
        //        internal class Program
        //        {
        //            private static void Main(string[] args)
        //            {
        //                string originalWord = "Developer";
        //                string reversedWord = ReverseWord(originalWord);
        //                Console.WriteLine($"The reversed word : is {reversedWord}");
        //            }


        //            static string ReverseWord(string word)
        //            {
        //                string reversedWord = "";

        //                for (int i = word.Length - 1; i >= 0; i--)
        //                {
        //                    reversedWord += word[i].ToString();
        //                }

        //                return reversedWord;
        //            }
        //        }
        //    }
    }


//using System;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            string notPalindrome = "potato";
//            bool result = IsPalindrome(notPalindrome);
//            Console.WriteLine($"Is {notPalindrome} a palindrome : {result}");

//            string palindrome = "mom";
//            result = IsPalindrome(palindrome);
//            Console.WriteLine($"Is {palindrome} a palindrome : {result}");
//        }

//        private static bool IsPalindrome(string word)
//        {
//            char[] array = word.ToCharArray();

//            Array.Reverse(array);

//            string reversedWord = new(array);

//            return reversedWord.Equals(word);
//        }
//    }
//}



//GetPatchVersionNumber("9.8.7") ➞ "7"

//string result = GetPatchVersionNumber("9.8.7");
//string message = $"{result} should equal 7";

//Console.WriteLine(message);

//result = GetPatchVersionNumber("29.48.17");
//message = $"{result} should equal 17";

//Console.WriteLine(message);

//private static string GetPatchVersionNumber(string patchNumber)
//{
//    string result = "";

//    //string[] dotSplitValues = patchNumber.Split('.');
//    //result = dotSplitValues[2];

//    List<string> parts = new List<string>();

//    string pastValues = "";
//    foreach (char item in patchNumber.ToCharArray())
//    {


//        if (item == '.')
//        {

//            parts.Add(pastValues);
//            pastValues = "";
//            continue;
//        }

//        pastValues += item.ToString();
//    }

//    parts.Add(pastValues);
//    result = parts.ToArray()[2];

//    return result;
//}



//using System;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            int mass = 60;
//            int velocity = 3;
//            double kineticEnergy = CalculateKineticEnergy(mass, velocity);

//            Console.WriteLine($"The kinetic energy given a mass of {mass} and a velocity of {velocity} is {kineticEnergy}.");
//        }

//        private static double CalculateKineticEnergy(int mass, int velocity)
//        {
//            double velocitySquared = Math.Pow(velocity, 2);
//            double massTimesVelocitySquared = mass * velocitySquared;
//            double kineticEnergy = .5 * massTimesVelocitySquared;
//            return kineticEnergy;
//        }
//    }
//}

//{


//    internal class Program
//{


//    private static void Main(string[] args)
//    {
//        int[] numberArray = new int[] { -1, 1, -2, 2 };

//        int computeNum = ComputeNumber(numberArray);

//        int expected = 6;


//        Console.WriteLine($"expected: {expected}");
//        Console.WriteLine($"Actual {computeNum}");




//    }

//    private static int ComputeNumber(int[] numberArray)
//    {
//        int sum = 0;

//        foreach (int number in numberArray)
//        {
//            if (number < 0)
//            {
//                sum += number * -1;
//                continue;
//            }

//            sum += number;

//            sum += Math.Abs(number);
//        }
//        return sum;


//    }
//}
//}



