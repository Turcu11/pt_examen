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
                Console.WriteLine("Please specify your option:");
                PrintOptions(text);
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

                    case 3:
                        text = InsertSubString(text);
                        Console.WriteLine(text);
                        break;

                    case 4:
                        text = ToUpperCase(text);
                        Console.WriteLine(text);
                        break;

                    case 5:
                        text = ToLowerCase(text);
                        Console.WriteLine(text);
                        break;

                }
                
            }
            while (option > 0);
        }

        public static void ShowResult(string result)
        {
            Console.WriteLine();
            Console.WriteLine(result);
        }

        public static void PrintOptions(string text)
        {
            Console.Clear();
            Console.WriteLine("1. Replace substring");
            Console.WriteLine("2. Remove substring");
            Console.WriteLine("3. Insert substring");
            Console.WriteLine("4. Get text to upper case");
            Console.WriteLine("5. Get text to lower case");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Hit 0 to quit");

            ShowResult(text);
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

        public static string InsertSubString(string text)
        {
            Console.Write("Plese enter the substring you want to insert:");
            string stringToInsert = Console.ReadLine();
            while (string.IsNullOrEmpty(stringToInsert))
            {
                CheckForNullOrEmptyString(stringToInsert);
            }
            Console.WriteLine("Please enter the starting point of te insert you want to make");
            string optionFromUser = Console.ReadLine();
            while(string.IsNullOrEmpty(optionFromUser))
            {
                CheckForNullOrEmptyString(optionFromUser);
            }
            int i = Convert.ToInt32(optionFromUser);
            return text.Insert(i, stringToInsert);
        }

        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }

        public static string ToLowerCase(string text)
        {
            return text.ToLower();
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
