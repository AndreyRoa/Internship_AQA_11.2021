using Intership_c3.Models;
using System.Collections.Generic;
using Intership_c3.Extensions;
using System;
using Intership_c3.Methods;
using Intership_c3.Enums;
using Intership_c3.Interfaces;

namespace Intership_c3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tutorList = new List<Tutor>();
            var studentList = new List<Student>();

            tutorList.AddPerson();
            tutorList.ShowAll();

            Person.Bla();
        }
    }
}
