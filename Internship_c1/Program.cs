using System;
using System.Text;

namespace Internship_c1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;

            //String b = "years";

            //Console.WriteLine(@$"\tI'm {a} {b}\\ young\ntest");

            //int a = 20;
            //int b = 10;
            //b += a; // b = b + a; 30
            //b -= a; // b = b - a; 10
            //b *= a; // b = b * a; 200
            //b /= a; // b = b / a; 10

            //if (a < b)
            //{
            //    Console.WriteLine("a < b");
            //}
            //else if(a == b)
            //{
            //    Console.WriteLine("a == b");
            //}
            //else{
            //    Console.WriteLine("else");
            //}

            //switch (a)
            //{
            //    case 1:
            //        break;
            //    case 2:
            //        break;
            //    default:
            //        break;
            //}

            //const int ARR_LEN = 10;

            //int[] nums = new int[4];

            //int[] nums2 = new int[4] { 1, 2, 3, 5 };

            //int[] nums3 = new int[ARR_LEN] { 1, 2, 3, 5, 876,6543,1,1,1,882};

            //int[] nums4 = new[] { 1, 2, 3, 5 };

            //int[] nums5 = { 1, 2, 3, 5 };

            //for(int item = 0; item < nums3.Length; item++)
            //{
            //    Console.WriteLine(nums3[item]);
            //}

            //string[] str = new[] { "a", "b", "c" };

            //int temp;

            //for (int i = 0; i < nums3.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < nums3.Length; j++)
            //    {
            //        if (nums3[i] < nums3[j])
            //        {
            //            temp = nums3[i];
            //            nums3[i] = nums3[j];
            //            nums3[j] = temp;
            //        }
            //    }
            //}

            //foreach(var item in nums3)
            //{
            //    Console.WriteLine(item);
            //}


            //var mon = Weekday.Monday;
            //var wed = (Weekday)2;
            //Console.WriteLine(wed);

            //var name = Console.ReadLine();

            //Console.WriteLine("Choose an action:\n" +
            //    "1. Say \"Hi\"\n" +
            //    "2. Say \"Hello\"");

            //var choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Hi();
            //        break;
            //    case 2:
            //       Hello();
            //        break;
            //    default:
            //        break;
            //}


            //int num1 = 1;

            //Dup1(num1);
            //Console.WriteLine(num1); // 1

            //Dup2(ref num1);
            //Console.WriteLine(num1); // 2

            //Sum(1, 2);
            //Sum(1,2,3);

            Console.WriteLine(Person.id);

            var pers = new Person();

            Console.WriteLine(Person.id);

            var pers1 = new Person();

            Console.WriteLine(Person.id);

            pers.ShowPassport();
        }

        public enum Gender
        {
            Male,
            Female,
            Unknown
        }

        public class Person
        {
            public static int id = 0;
            public string FirstName 
            {
                get;
                set;
            }
            public Gender Gender { get; set; }
            public string LastName { get; set; }
            public DateTimeOffset BirthDate;
            public int Age {
                get => DateTimeOffset.UtcNow.Year - BirthDate.Year;
            }

            public Person()
            {
                ++id;
                Gender = Gender.Unknown;
                FirstName = "Vasya";
                LastName = "Vasiliev";
            }

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public void ShowPassport()
            {
                Act();
                Console.WriteLine($"FirstName: {FirstName}\nLast Name: {LastName}\nAge: {Age}, Gender: {Gender}");
            }

            private void Act()
            {
                Console.WriteLine("Put passport");
            }
        }

        public static int ToInt(string number) => int.Parse(number);

        //public static int ToInt(string number)
        //{
        //    return int.Parse(number);
        //}

        public static void Hello()
        {
            Console.WriteLine($"Hello");
        }

        public static void Hi()
        {
            Console.WriteLine($"Hi");
        }

        enum Weekday : int
        {
            Monday,
            Friday,
            Wednesday
        }
        
        public static void Dup2(ref int number)
        {
            number *= 2;
        }

        public static void Dup1(int number)
        {
            number *= 2;
        }

        public static void Sum(params int[] numbers)
        {
            var totalSum = 0;
            foreach (var num in numbers)
            {
                totalSum += num;
            }

            Console.WriteLine(totalSum);
        }
    }
}
