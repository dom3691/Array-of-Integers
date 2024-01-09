using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter element {i + 1}:");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Total Score: {GetScore(array)}");
    }

    public static int GetScore(int[] array)
    {
        int score = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                score += 1;
            }
            else
            {
                score += 3;
            }

            if (num == 8)
            {
                score += 5;
            }
        }
        return score;
    }
}