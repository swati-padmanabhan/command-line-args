using System;
using System.Linq;
public class CommandLineArgs
{
    public static void Main(string[] args)
    {
        int[] array = new int[5];

        int firstNumber = Convert.ToInt32(args[0]);
        int secondNumber = Convert.ToInt32(args[1]);
        int thirdNumber = Convert.ToInt32(args[2]);
        int fourthNumber = Convert.ToInt32(args[3]);
        int fifthNumber = Convert.ToInt32(args[4]);

        for (int i = 0; i < 5; i++)
        {
            array[i] = Convert.ToInt32((args[i]));
        }


        int max = array[0];
        int min = array[0];
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine("The Minimum value is: " +min);
        Console.WriteLine("The Maximum value is: " +max);

        int CountOfElements = array.Count();
        Console.WriteLine("Count of Elements are: "+CountOfElements);

        int sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
        double avg = sum / 5.0;

        Console.WriteLine("The Sum of 5 numbers is: " +sum);
        Console.WriteLine("The Average of 5 numbers is: " +avg);
    }
}
