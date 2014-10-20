using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace Calculator
{
    class IO
    {
        static void Main(string[] args)
        {
            BinTree tree = new BinTree();
            string input =  Console.ReadLine();
            Parsing.Parse(input, tree);

        }
    }


}
