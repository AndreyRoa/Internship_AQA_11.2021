using Intership_c3.Interfaces;
using System;
using System.Collections.Generic;

namespace Intership_c3.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void AddPerson<T>(this ICollection<T> personList)
            where T : ISetModel, new()
        {
            var person = new T();

            person.Fill();

            personList.Add(person);
        }
        public static void ShowAll<T>(this ICollection<T>personList)
            where T : IGetModel
        {
            foreach (var person in personList)
            {
                Console.WriteLine(person.GetInfo());
            }
        }
    }
}
