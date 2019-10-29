using System;

namespace Min_max_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];

            numbers[0] = 15;
            numbers[1] = 22;
            numbers[2] = 84;
            numbers[3] = 14;
            numbers[4] = 88;
            numbers[5] = 23;

            int highest_value = 88;
            int smallest_value = 14;

            int difference = highest_value - smallest_value;

            Console.Write(difference);

            Console.ReadLine();

        }
    }
}
