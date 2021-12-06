using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intership_c3.Models
{
    public class Student : Tutor
    {
        public int? Grade { get; set; }

        public Student() : base()
        {
            Console.WriteLine(typeof(Student));
        }


        public override string GetInfo()
        {
            return string.Concat(base.GetInfo(), "\nGrade: ", Grade);
        }

        public override void Fill()
        {
            int grade;
            base.Fill();
            while (true)
            {
                Console.Write("Enter the grade: ");
                if(int.TryParse(Console.ReadLine(), out grade))
                {
                    Grade = grade;
                    return;
                }
            }
        }
    }
}
