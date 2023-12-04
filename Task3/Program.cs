using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///// part 1 /////

            //int[] ARR = { 1, 7, 9, 45 };
            //string[] arr2 = { "Str" ,"alex", "moh" };
            //string[] arr3 = { "the", "fox" , "over", "lazy", "dog"};


            ///// part 2 /////

            //String[] fruits = { "Tomato", "Banana", "Watermelon" };
            //fruits[0]="Tomato"
            //fruits[1] = "Banana"
            //fruits[2] = "Watermelon"



            ///// part 3 /////

            //string[] favoriteFoods = { "Pizza", "Sushi", "Chocolate", "Burgers", "Ice Cream" };
            //string[] favoriteSports = { "Soccer", "Basketball", "Tennis" };
            //string[] favoriteMovies = { "Inception", "The Shawshank Redemption", "The Matrix", "Pulp Fiction" };

            //// Printing favorite foods using foreach loop
            //Console.WriteLine("Favorite Foods:");
            //foreach (string food in favoriteFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //Console.WriteLine("\nFavorite Sports:");
            //// Printing favorite sports using foreach loop
            //foreach (string sport in favoriteSports)
            //{
            //    Console.WriteLine(sport);
            //}

            //Console.WriteLine("\nFavorite Movies:");
            //// Printing favorite movies using foreach loop
            //foreach (string movie in favoriteMovies)
            //{
            //    Console.WriteLine(movie);
            //}



            ///// part 4 /////

            //Console.Write("Input three numbers separated by comma: ");
            //string inputLine = Console.ReadLine();
            //string[] numbers = inputLine.Split(',');
            //int sum = 0;
            //foreach (string number in numbers)
            //{
            //    if (int.TryParse(number, out int parsedNumber))
            //    {
            //        sum += parsedNumber;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter valid numbers separated by commas.");
            //        return;
            //    }
            //}

            //Console.WriteLine($"The sum of three numbers: {sum}.");

            ///// part 5 /////

            //int upperLimit = 100;
            //int sum = 0;
            //Console.WriteLine("Odd numbers from 1 to 100:");

            //for (int i = 1; i <= upperLimit; i += 2)
            //{
            //    Console.Write(i + " ");
            //    sum += i;
            //}

            //Console.WriteLine("\nThe Sum of odd Numbers is: " + sum);

            ///// part 6  /////


            //int rows = 3;
            //Console.WriteLine("Right-Angled Triangle Pattern:");

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}


            ///// part 7 /////

            //int rows = 4;
            //Console.WriteLine("right angle triangle with numb:");
            //int num = 1;
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k=1; k <= i; k++)
            //    {
            //        Console.Write(num);
            //        num++;
            //    }

            //    Console.WriteLine();
            //}
        }


        

    }   
}
