using System;

namespace pt_examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //ComapreKidsAge();
            SumOfNumbersFromUser();

        }

        public static void ComapreKidsAge()
        {
            int ageX = Convert.ToInt32(Console.ReadLine());
            int ageY = Convert.ToInt32(Console.ReadLine());

            if (ageX == ageY)
            {
                Console.WriteLine($"The ages are the same.");
            }
            else if (ageX > ageY)
            {
                Console.WriteLine($"The first kid is older by {ageX - ageY}");
            }
            else
            {
                Console.WriteLine($"The first kid is older by {ageY - ageX}");
            }
        }


        /// <summary>
        /// This function shoul, at least in theory return the sum of some numbers, till you enter 2 identical numbers in a row
        /// </summary>
        /// <returns></returns>
        public static int SumOfNumbersFromUser()
        {
            int currentValue = Convert.ToInt32(Console.ReadLine());
            int previousValue = Convert.ToInt32(Console.ReadLine());
            int sum = currentValue;
            if (currentValue == previousValue)
            {
                sum = sum + previousValue;
            }
            while (currentValue != previousValue)
            {
                sum = sum + previousValue;
                previousValue = Convert.ToInt32(Console.ReadLine());
                currentValue = previousValue;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
