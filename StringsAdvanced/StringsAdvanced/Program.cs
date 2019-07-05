using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {


            ReturnMiddleCharacters();
            CountOccurrences();
            LikeSystem();
            Console.WriteLine("Santa's learning to code. Please type \"ho\"");
            Console.WriteLine(Ho());
            Console.WriteLine(Ho(Ho()));
            Console.WriteLine(Ho(Ho(Ho())));


        }



        public static void ReturnMiddleCharacters()
        {
            Console.WriteLine("This method returns the middle character. Please type a word.");
            string word = Console.ReadLine();
            int middleChar = word.Length / 2;
            StringBuilder final = new StringBuilder();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("You didn't typed anything.");

                return;
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Length == 1)
                {
                    final.Append(word);
                    Console.WriteLine($"You typed only one character so the string remains the same : {final}");
                }
                else if (word.Length < 999 && word.Length % 2 == 0)
                {
                    final.Append(word[middleChar - 1] + word[middleChar].ToString());
                    Console.WriteLine($"This word's length was even so it returns the  two middle characters : {final}");
                    return;
                }
                else if (word.Length < 999 && word.Length % 2 == 1)
                {
                    final.Append(word[middleChar].ToString());
                    Console.WriteLine($"This string's length was odd so it returns the middle character : {final}");
                    return;
                }
            }
        }

        public static void CountOccurrences()
        {
            Console.WriteLine("This method will count occurrences from a string and one or multiple characters.\nPlease type something");
            string line = Console.ReadLine();
            StringBuilder final = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                if (!line.Contains("z"))
                {
                    Console.WriteLine("The string didn't contained the letter \'z\'!");
                    return;
                }
                if (line.Length == 1 && line.Contains("z"))
                {
                    final.Append(line);
                    Console.WriteLine($"You typed only one character so there are no occurrences");
                    return;
                }

                else if (line.Length >= 2 && line.Contains("z") && line.Contains(" "))
                {
                    line = line.Remove(line.IndexOf(" ")).ToString();
                    final.Append(line.Where(x => x == 'z').Count());
                    Console.WriteLine($"The occurrences of \'z\' in this string : {final}");
                    return;
                }
                else if (!line.Contains(" "))
                {
                    final.Append(line.Where(x => x == 'z').Count());
                    Console.WriteLine($"The occurrences of \'z\' are : {final}, but the string didn't contained the Separated character \'z\'.");
                    return;
                }

            }

        }



        public static void LikeSystem()
        {
            Console.WriteLine("This method will read from the keyboard some names and accordingly to the number of names you type," +
                "\nit will tell you how many people liked your picture." +
                "You can type a maximum of four names.");

            List<string> List = new List<string> ();
            List.Add(Console.ReadLine());
            List.Add(Console.ReadLine());
            List.Add(Console.ReadLine());
            List.Add(Console.ReadLine());
            if (string.IsNullOrEmpty(List.ToString()))
            {
                Console.WriteLine("You didn't typed any names!");
                return;
            }
            foreach(string value in List)
            {
                if (!string.IsNullOrEmpty(List.ToString()) && List.ToString().Length > 0)
                {
                    Console.WriteLine($"{String.Join(" ", List)} liked your photo!");
                    return;
                }
              
            }
         
        }
            
        
        static string Ho()
        {

            return Console.ReadLine().ToUpper();
            
        }
        static string Ho(string ho)
        {
            return "HO " + ho.ToUpper();
        }


    }
}
