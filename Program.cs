using System;
using System.Collections.Generic;

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
                Console.WriteLine("Please ")
            }



        }
    }
}
