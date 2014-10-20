using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{

    public class Node
    {
        public object Value;
        public Node Left;
        public Node Right;

        public Node()
        {
            this.Value = null;
        }

        public Node(object Value)
        {
            this.Value = Value;
        }

    }

    public class BinTree
    {
        public Node Current;

        public BinTree()
        {
            Current = null;
        }

        public void AddToTree(object obj, bool isdigit = true)
        {
            if (isdigit)
            {
                if (this.Current == null)
                {
                    Current = new Node();
                    Current.Left = new Node(Convert.ToDouble(obj));
                }

                else
                {
                    if (this.Current.Left == null)
                    {
                        Current.Left = new Node(Convert.ToDouble(obj));
                    }

                    else if (this.Current.Right == null)
                    {
                        this.Current.Right = new Node(Convert.ToDouble(obj));
                    }

                    else
                    {
                        Node newnode = new Node(obj);
                        newnode.Left = Current;
                        Current = newnode;
                    }
                }

            }

            else
            {
                if (this.Current.Value == null)
                {
                    this.Current.Value = obj;
                }

                else
                {
                    Node newnode = new Node(obj);
                    newnode.Left = this.Current;
                    this.Current = newnode;
                }

            }
        }

    }

    public static class Parsing
    {
        public static char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', ',' };
        public static char[] acts = { '+', '-', '*', '/', '^', '%' };

        public static void Parse(string str, BinTree tree)
        {
            char[] srt;
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (digits.Contains(str[i]))
                {
                    counter = 0;
                    while (digits.Contains(str[i]))
                    {
                        counter++;
                        i++;
                        if (i>=str.Length)
                        {
                            break;
                        }
                    }
                    srt = new char[counter];
                    str.CopyTo(i - counter, srt, 0, counter);
                    tree.AddToTree(new string(srt));
                    i -= 1;
                    continue;
                }

                if (acts.Contains(str[i]))
                {
                    counter = 0;
                    while (!digits.Contains(str[i]))
                    {
                        counter++;
                        i++;
                    }
                    srt = new char[counter];
                    str.CopyTo(i - counter, srt, 0, counter);
                    tree.AddToTree(new string(srt), false);
                    i--;
                    continue;
                }






            }
        }
    }
}
