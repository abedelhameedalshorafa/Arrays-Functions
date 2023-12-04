using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////  functions  ///////////////////////////


            ////// part 1 //////


            //    int[] numbers = new int[10];
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.Write($"Number-{i + 1}: ");
            //        while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number.");
            //            Console.Write($"Number-{i + 1}: ");
            //        }
            //    }

            //    CalculateSumAndAverage(numbers, out int sum, out double average);
            //    Console.WriteLine($"\nThe sum of 10 numbers is: {sum}");
            //    Console.WriteLine($"The average is: {average:F6}");



            ////// part 2 //////

            //int[] numbers = new int[5];
            //Console.WriteLine("Please Enter 5 Numbers :");
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    if(!int.TryParse(Console.ReadLine(),out numbers[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //        Console.Write($"Number-{i + 1}: ");
            //    }
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"number is : {numbers[i]} and cobe of the {numbers[i]} is {cube(numbers[i])}");   
            //}


            ///// part3 /////

            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            //int[] filteredYears = GetYears(years);

            //Console.WriteLine("Years greater than 1950:");
            //foreach (int year in filteredYears)
            //{
            //    Console.WriteLine(year);
            //}


            ///// part 4 /////
            ///

            //Console.WriteLine("Please Enter Your age : ");
            //int age;
            //if(!int.TryParse(Console.ReadLine(),out age))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}
            //Console.WriteLine($"Your age in days: {getAgeInDays(age)}");


            ///// part 5 /////


            //int totalLegs = CountLegs(2, 3, 5);
            //Console.WriteLine($"Total number of legs: {totalLegs}");


            ///// part 6 /////

            //string username = "user1";
            //string password = "password123";

            //string result = Login(username, password);

            //Console.WriteLine(result);


            ///// part 7 /////

            //Console.WriteLine("Please Enter Your Number and Exponent");
            //if(!double.TryParse(Console.ReadLine(),out double number))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}
            //if (!double.TryParse(Console.ReadLine(), out double exponent))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}
            //Console.WriteLine("the poser of number is :"+calcPower(number,exponent));


            ///// part 8 /////


            //Console.WriteLine("Please Enter The Year :");
            //if (!int.TryParse(Console.ReadLine(), out int year))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}

            //if (IsLeapYear(year))
            //{
            //    Console.WriteLine($"{year} is a leap year.");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} is not a leap year.");
            //}


            ///// part 9 /////


            //Console.WriteLine("Please Enter Your Number :");
            //if (!int.TryParse(Console.ReadLine(), out int number))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}

            //if (IsPrime(number))
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}



            ///// part 10 /////


            //string sentence = "a Abed is Afantastic man a";
            //Console.WriteLine($"number of words is : {calcNumberOfWords(sentence)}");
        }

        //static int calcNumberOfWords(string sentence)
        //{
        //    int count = 0;
        //    for(int i=0;i<sentence.Length;i++)
        //    {
        //        if(i!=sentence.Length-1)
        //        {
        //            if (sentence[i] == ' ' && sentence[i + 1] != ' ')
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    if(sentence[0]!=' ')
        //    {
        //        count++;
        //    }
        //    return count;
        //}

        //static bool IsPrime(int number )
        //{
        //    if(number<=1)
        //    {
        //        return false;
        //    }
        //    for(int i=2;i<=Math.Sqrt(number);i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}


        //static bool IsLeapYear(int year)
        //{
        //    if (year < 1900 || year > 2024)
        //    {
        //        throw new ArgumentOutOfRangeException("Year must be in the range 1900-2024.");
        //    }

        //    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //static double calcPower(double number,double e)
        //{
        //    return Math.Pow(number,e);
        //}


        //static string Login(string inputUsername, string inputPassword)
        //{
        //    string[] validUsernames = { "user1", "user2", "user3" };
        //    string[] validPasswords = { "password123", "secret456", "pass789" };

        //    for (int i = 0; i < validUsernames.Length; i++)
        //    {
        //        if (inputUsername == validUsernames[i] && inputPassword == validPasswords[i])
        //        {
        //            return "Login passed!";
        //        }
        //    }
        //    return "Login failed!";
        //}

        //static int CountLegs(int chickens, int cows, int pigs)
        //{
        //    int chickenLegs = chickens * 2;
        //    int cowLegs = cows * 4;
        //    int pigLegs = pigs * 4;

        //    return chickenLegs + cowLegs + pigLegs;
        //}

        //static int getAgeInDays(int age)
        //{
        //    const int daysForOneYear = 365;
        //    return age * daysForOneYear;
        //}

        //static int[] GetYears(int[] years)
        //{
        //    int count = 0;

        //    foreach (int year in years)
        //    {
        //        if (year > 1950)
        //        {
        //            count++;
        //        }
        //    }

        //    int[] result = new int[count];
        //    int i = 0;

        //    foreach (int year in years)
        //    {
        //        if (year > 1950)
        //        {
        //            result[i]=year;
        //            i++;
        //        }
        //    }

        //    return result;
        //}


        //static int cube(int number)
        //{
        //    return number * number * number;
        //}



        //static void CalculateSumAndAverage(int[] numbers, out int sum, out double average)
        //{
        //    sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        sum += number;
        //    }
        //    average = (double)sum / numbers.Length;
        //}
    }
}
