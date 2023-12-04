using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            ///// part 1 /////


            //int minutes = 5;

            //int seconds = ConvertMinutesToSeconds(minutes);

            //Console.WriteLine($"{minutes} minutes is equal to {seconds} seconds.");


            ///// part 2 /////

            //int inputNumber = 7;

            //int result = IncrementByOne(inputNumber);

            //Console.WriteLine($"Original number: {inputNumber}");
            //Console.WriteLine($"Incremented number: {result}");



            ///// part 3 /////


            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"The First Element In Array is : {getFirstElement(numbers)} ");


            ///// part 4 /////

            //double height = 4.5;
            //double basee = 4.5;
            //Console.WriteLine($"The Area Of Trianle is : {calcArea(height,basee)} ");

            ///// part 5 /////

            //int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };

            //int[] result = EvenNumberEvenIndex(nums);

            //Console.Write("Original array: ");
            //PrintArray(nums);

            //Console.Write("Result array: ");
            //PrintArray(result);


            ///// part 6 /////


            //string[] words = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };

            //string[] result = evenIndexOddLength(words);

            //Console.Write("Original array: ");
            //PrintArray(words);

            //Console.Write("Result array: ");
            //PrintArray(result);


            ///// part 7 /////

            //int[] nums = { 5, 2, 2, 1,5  };

            //double[] result = powerElementIndex(nums);

            //Console.Write("Original array: ");
            //PrintArray(nums);

            //Console.Write("Result array: ");
            //PrintArray(result);


            ///// part 8 /////


            //Console.WriteLine($"the multiplication of 5 and 4 is : {multiplication(4,5)}"); 

            ///// part 9 /////

            //Console.WriteLine($"the multi of 3 and 6 is : {multi(3, 6)}");


            ///// part 10 /////


            //int[] numbers = { 1, 4, 7, 8, 5, 6, 11 };
            //Console.WriteLine($"The Average of Numbers is : {aveArray(numbers)}");


        }


        //static double aveArray(int[] numbers)
        //{
        //    double average = (double)numbers.Sum() / numbers.Length;
        //    return average;
        //}

        //static double multi(double num1,double num2)
        //{
        //    double multi = num1;
        //    for(double i=num1+1;i<=num2;i++)
        //    {
        //        multi *= i;
        //    }
        //    return multi;
        //}



        //static double multiplication(double num1,double num2)
        //{
        //    double sum = 0;
        //    for(int i=1;i<=num2;i++)
        //    {
        //        sum += num1;
        //    }
        //    return sum;
        //}


        //static double[] powerElementIndex(int[] nums)
        //{

        //    double[] result = new double[nums.Length];
        //    int j = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        result[j] = Math.Pow((double)nums[i], (double)i);
        //        j++;
        //    }

        //    return result;
        //}

        //static void PrintArray(int[] array)
        //{
        //    foreach (int num in array)
        //    {
        //        Console.Write($"{num} ");
        //    }
        //    Console.WriteLine();
        //}
        //static void PrintArray(double[] array)
        //{
        //    foreach (int num in array)
        //    {
        //        Console.Write($"{num} ");
        //    }
        //    Console.WriteLine();
        //}

        //static string[] evenIndexOddLength(string[] words)
        //{
        //    int count = 0;
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (i % 2 == 0 && words[i].Length % 2 == 1)
        //        {
        //            count++;
        //        }

        //    }
        //    string[] result = new string[count];
        //    int j = 0;
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (i % 2 == 0 && words[i].Length % 2 == 1)
        //        {
        //            result[j] = words[i];
        //            j++;
        //        }
        //    }

        //    return result;
        //}

        //static void PrintArray(string[] words)
        //{
        //    foreach (string word in words)
        //    {
        //        Console.Write($"{word} ");
        //    }
        //    Console.WriteLine();
        //}

        //static int[] EvenNumberEvenIndex(int[] nums)
        //{
        //    int count=0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (i % 2 == 0 && nums[i] % 2 == 0)
        //        {
        //            count++;
        //        }

        //    }
        //    int[] result =new int[count];
        //    int j = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (i%2==0 && nums[i] % 2 == 0)
        //        {
        //            result[j] =nums[i];
        //            j++;
        //        }
        //    }

        //    return result;
        //}

        //static void PrintArray(int[] array)
        //{
        //    foreach (int num in array)
        //    {
        //        Console.Write($"{num} ");
        //    }
        //    Console.WriteLine();
        //}

        //static double calcArea(double height,double basee)
        //{
        //    return 0.5 * height * basee;
        //}

        //static int getFirstElement(int[] numbers)
        //{
        //    return numbers[0];
        //}

        //static int IncrementByOne(int number)
        //{
        //    return number + 1;
        //}


        //static int ConvertMinutesToSeconds(int minutes)
        //{
        //    return minutes * 60;
        //}
    }
}
