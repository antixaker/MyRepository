using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGeneric;

namespace TestMyGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> generic_int = new MyList<int>();
            generic_int.Add(-1);
            generic_int.Add(2);
            generic_int.Add(3);

            MyList<float> genfloat = new MyList<float>();
            genfloat.Add(2.45f);
            genfloat.Add(2.46f);
            genfloat.Add(2.47f);
            genfloat.Add(2.48f);
            genfloat.Add(2.49f);
            Console.WriteLine("Друкуемо раз:");
            foreach (var item in generic_int)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Друкуемо два:");
            foreach (var item in genfloat)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(generic_int.IndexOf(2));
            generic_int.Remove(2);
            Console.WriteLine(generic_int.IndexOf(2));
            Console.WriteLine("Писля удаления:");
            foreach (var item in generic_int)
            {
                Console.WriteLine(item);
            }

        }
    }
}
