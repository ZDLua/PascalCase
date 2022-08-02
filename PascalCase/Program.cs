using System;

namespace PascalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string catName = "Terry";
            int catAge = 12;
            int dayNum = 2;
            int monthDay = 2;
            int year = 2020;

            Console.WriteLine($"My cat's name is {catName}, He is {catAge} years old. He was adopted on {monthDay}/{dayNum}/{year} ");
        }
    }
}

