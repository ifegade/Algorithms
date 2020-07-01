using System;
namespace Algorithm
{
    public class RandomNumberWithBinarySearch
    {



        public void FindAndCalculateMoves()
        {
            int start = 1;
            int end = 500000000;
            int count = 0;
            Random rand = new Random();
            int number = rand.Next(start, end);
            int generatedNumber = rand.Next(start, end);

            while (generatedNumber != number)
            {
                if (number > generatedNumber)
                    start = generatedNumber;
                else
                    end = generatedNumber;
                generatedNumber = rand.Next(start, end);
                count++;
            }
            Console.WriteLine($"Numbers of moves == {count}");
        }

    }
}
