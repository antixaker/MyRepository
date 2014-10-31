using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;
using System.Globalization;

namespace Calculator
{
    class IO
    {
        static void Main(string[] args)
        {
            BinTree tree;
            string input = Console.ReadLine();
            tree = Parsing.Parse(input);
           // Console.WriteLine(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);

        }
    }


}
