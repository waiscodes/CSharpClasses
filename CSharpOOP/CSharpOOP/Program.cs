using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("State your name cuz");
            person.FirstName = Console.ReadLine().Trim();

            Console.WriteLine("State your name cuz");
            person.LastName = Console.ReadLine().Trim();

            Console.WriteLine($"hello {person.FirstName} {person.LastName}");

        }
    }
}
