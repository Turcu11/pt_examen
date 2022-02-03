using System;

namespace pt_examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome !");
            Console.WriteLine("Please enter a word:");
            string text = Console.ReadLine();
            while(String.IsNullOrEmpty(text))
            {
                Console.WriteLine("You have to write something...try again: ");
                text = Console.ReadLine();
            }
            int option = 0;
            do
            {
                Console.Write("Please specify your option:");
                string optionFromUser = Console.ReadLine();
                while(string.IsNullOrEmpty(optionFromUser))
                {
                    CheckForNullOrEmptyString(optionFromUser);
                }
                option = Convert.ToInt32(optionFromUser);
                switch (option)
                {
                    case 1:
                        text = ReplaceSubString(text);
                        Console.WriteLine(text); ;
                        break;

                    case 2:
                        text = RemoveSubString(text);
                        Console.WriteLine(text);
                        break;

                }
                
            }
            while (option > 0);
        }

        public static string ReplaceSubString(string text)
        {
            Console.Write("Please enter the substring you want to change:");
            string stringToBeReplaced = Console.ReadLine();
            while (String.IsNullOrEmpty(stringToBeReplaced))
            {
                CheckForNullOrEmptyString(stringToBeReplaced);
            }
            string stringToReplaceWith = Console.ReadLine();
            while (String.IsNullOrEmpty(stringToReplaceWith))
            {
                CheckForNullOrEmptyString(stringToReplaceWith);
            }
            return text.Replace(stringToBeReplaced, stringToReplaceWith);
        }

        public static string RemoveSubString(string text)
        {
            Console.Write("Please enter the substring you want to remove:");
            string stringToBeRemoved = Console.ReadLine();
            while (String.IsNullOrEmpty(stringToBeRemoved))
            {
                CheckForNullOrEmptyString(stringToBeRemoved);
            }
            int i = text.IndexOf(stringToBeRemoved);
            while(i >= 0)
            {
                text = text.Remove(i, stringToBeRemoved.Length);
                i = text.IndexOf(stringToBeRemoved);
            }
            return text;
        }


        public static string CheckForNullOrEmptyString(string stringToCheck)
        {
            while (String.IsNullOrEmpty(stringToCheck))
            {
                Console.WriteLine("You have to write something...try again: ");
                stringToCheck = Console.ReadLine();
            }
            return stringToCheck;
        }
    }
}
