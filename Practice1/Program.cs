using System;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registration Form ");
            Console.WriteLine();
            Console.Write("First name: ");
            string firstname = Console.ReadLine();
            Console.Write("Last name: ");
            string lastname = Console.ReadLine();
            Console.Write("Birth year: ");
            string birthyear = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " + firstname + " " + lastname);
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + firstname + "*" + birthyear);
        }
    }
}
