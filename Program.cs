using System;

namespace DictionaryPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter name:");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter phone number associated with {name}:");
            var phoneNum = Console.ReadLine();
        }
    }
}
