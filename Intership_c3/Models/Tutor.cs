using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intership_c3.Models
{
    public class Tutor : Person
    {
        public bool? Knowledge { get; set; }

        public Tutor() : base()
        {
            Console.WriteLine(typeof(Tutor));
        }

        public override string GetInfo()
        {
            return string.Concat(base.GetInfo(), "\nKnows: ", Knowledge);
        }

        public override void Fill()
        {
            base.Fill();
            bool knows;

            for (; ; )
            {
                Console.Write("Does he know? ");
                if(bool.TryParse(Console.ReadLine(), out knows))
                {
                    Knowledge = knows;
                    return;
                }
            }
        }
    }
}
