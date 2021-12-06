using Intership_c3.Interfaces;
using System;

namespace Intership_c3.Models
{
    public abstract class Person : IGetModel, ISetModel
    {
        private static int _id = 0;

        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() : this("Unknown")
        {
            Console.WriteLine(typeof(Person));
        }

        public Person(string firstName) : this(firstName, "Unknown")
        {
        }

        public Person(string firstName, string lastName)
        {
            Id = ++_id;
            FirstName = firstName;
            LastName = lastName;
        }

        public static void Bla()
        {
            Console.WriteLine("Bla");
        }

        public virtual string GetInfo()
        {
            return string.Concat($"Id: {Id}", "\nFirst Name: ", FirstName, "\nLast Name: ", LastName);
        }

        public virtual void Fill()
        {
            Console.Write("Enter the first name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter the nast name: ");
            LastName = Console.ReadLine();
        }
    }
}
