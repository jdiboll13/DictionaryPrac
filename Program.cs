using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<string, int>();
            var name = "space";
            while (name != string.Empty)
            {
                Console.WriteLine("Please enter name:");
                name = Console.ReadLine();
                if (name != string.Empty)
                {
                    Console.WriteLine($"Please enter phone number associated with {name}:");
                    var phoneNum = int.Parse(Console.ReadLine());
                    myDictionary.Add(name, phoneNum);
                }
            }

            var lookUp = "Placeholder";
            while (lookUp != string.Empty)
            {
                Console.WriteLine("Please enter a name you would like to look-up:");
                lookUp = Console.ReadLine();
                int phoneNumber = 0;
                if (myDictionary.TryGetValue(lookUp, out phoneNumber))
                {
                    Console.WriteLine($"{phoneNumber}");
                }
                else if (lookUp != string.Empty)
                {
                    Console.WriteLine($"Have you tried:");
                    foreach (var item in myDictionary)
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                }
            }
            string s = "abcabcabcdefab c a oo ija ;a ;skmdals kn";
            Console.WriteLine(letterCount(s)['b'] == 4);
            Console.WriteLine(letterCount(s).ContainsKey('z') == false);
        }
        public static Dictionary<char, int> letterCount(string s)
        {
            var lowerCase = s.ToLower().ToCharArray();
            var charDictionary = new Dictionary<char, int>();
            foreach (var item in lowerCase)
            {
                var count = lowerCase.Where(l => l == item).Count();
                if (charDictionary.ContainsKey(item) == false)
                {
                    charDictionary.Add(item, count);
                }
            }
            return charDictionary;
        }
    }
}
