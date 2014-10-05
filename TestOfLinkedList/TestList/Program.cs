using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLinkedList;

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            OwnLinkedList<int> doublelist = new OwnLinkedList<int>();
            doublelist.AddFirst(0);
            doublelist.AddFirst(1);
            doublelist.AddFirst(2);
            doublelist.AddFirst(3);
            doublelist.AddLast(-1);
           // doublelist.Remove(2);
            doublelist.RemoveFirst();
            doublelist.RemoveLast();
            //foreach ( Node<int> item in doublelist)
            //{
            //    Console.WriteLine(item.Value);  
            //}

        }
    }
}
