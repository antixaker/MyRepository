using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace TestOfLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary.MyList test = new MyList();
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);
            test.Add(9);
            test.Add(10);
            test.Add(11);

            while (test.MoveNext())
            {
                Console.WriteLine(test.Current);
            }
        }
    }
}
