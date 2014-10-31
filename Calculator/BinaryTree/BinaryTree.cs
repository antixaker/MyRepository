using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

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
        public Node Current, Root;

        public BinTree()
        {
            Current = Root = null;
        }
        object last;
        public void AddToTree(object obj, bool isdigit = true, int brackets = 0)
        {
            if (isdigit)
            {

                if (this.Current == null)
                {
                    Current = new Node();
                    if (obj is BinaryTree.Node)
                    {
                        Current.Left = (Node)obj;
                    }
                    else
                    {
                        Current.Left = new Node(obj);//Convert.ToDouble(obj));
                    }
                }

                else
                {
                    if (obj is BinaryTree.Node)
                    {
                        if (this.Current.Left == null)
                        {
                            Current.Left = (Node)obj;
                        }

                        else if (this.Current.Right == null)
                        {
                            this.Current.Right = (Node)obj;
                        }

                        else
                        {
                            Node newnode = new Node(obj);
                            newnode.Left = Current;
                            Current = newnode;
                        }
                    }
                    else
                    {
                        if (this.Current.Left == null)
                        {
                            Current.Left = new Node(obj);//Convert.ToDouble(obj));
                        }

                        else if (this.Current.Right == null)
                        {
                            this.Current.Right = new Node(obj);//Convert.ToDouble(obj));
                        }

                        else
                        {
                            Node newnode = new Node(obj);
                            newnode.Left = Current;
                            Current = newnode;
                        }
                    }

                }
                if (last != null)
                {

                    if (!(last.Equals("*") || last.Equals("/") || last.Equals("%")))
                    {
                        Root = Current;
                    }
                }

            }

            else
            {
                if (obj.Equals("+") || obj.Equals("-"))
                {
                    if (Root != null)
                    {
                        Current = Root;
                    }
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
                    //if (brackets == 0)
                    //{

                    //}
                    Root = Current;
                }
                else if (obj.Equals("*") || obj.Equals("/") || obj.Equals("%"))
                {
                    if (this.Current.Value == null)
                    {
                        this.Current.Value = obj;
                    }

                    else
                    {
                        //if (Root==null)
                        //{
                        //    Root = Current;
                        //}
                        //Root = Current;
                        Node newnode = new Node(obj);
                        newnode.Left = new Node(Current.Right.Value);
                        this.Current.Right = newnode;
                        if (brackets == 0)
                        {
                            Root = Current;
                        }
                        this.Current = newnode;
                    }
                }


            }
            last = obj;
        }

    }

    public static class Parsing
    {
        static char decimalSeparator = Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
        public static char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', decimalSeparator };
        public static char[] acts = { '+', '-', '*', '/', '^', '%' };

        public static BinTree Parse(string str)
        {
            BinTree tree = new BinTree();
            string substring;
            int counter = 0, counterOfBrackets = 0;
            bool isDecimalSeparator;
            for (int i = 0; i < str.Length; i++)
            {
                isDecimalSeparator = false;

                if (str[i] == '(')
                {
                    counter = 0;
                    counterOfBrackets++;
                    while (counterOfBrackets > 0)
                    {
                        i++;
                        if (i >= str.Length)
                        {
                            break;
                        }
                        if (str[i] == ')')
                        {
                            counterOfBrackets--;
                        }
                        else if (str[i] == '(')
                        {
                            counterOfBrackets++;
                        }
                        counter++;
                    }
                    //i--;
                    substring = str.Substring(i - counter + 1, counter - 1);
                    BinTree tmpTree = Parse(substring);
                    tree.AddToTree(tmpTree.Root, true, 1);
                    //i += 2;
                    continue;
                }

                if (digits.Contains(str[i]))
                {
                    counter = 0;
                    while (digits.Contains(str[i]))
                    {
                        counter++;
                        i++;
                        if (i >= str.Length)
                        {
                            break;
                        }
                    }
                    substring = str.Substring(i - counter, counter);
                    if (substring.Contains(decimalSeparator))
                    {
                        isDecimalSeparator = true;
                    }
                    tree.AddToTree(WhatTypeOfObject(substring, isDecimalSeparator));
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
                        if (str[i] == '(' | str[i] == ')')
                        {
                            break;
                        }
                    }
                    substring = str.Substring(i - counter, counter);
                    tree.AddToTree(WhatTypeOfObject(substring, isDecimalSeparator), false);
                    i--;
                    continue;
                }
            }
            return tree;
        }

        static object WhatTypeOfObject(object obj, bool isdecimal)
        {
            if (isdecimal)
            {
                try
                {
                    double number = Convert.ToDouble(obj);
                    return number;
                }
                catch (System.OverflowException)
                {
                    decimal number = Convert.ToDecimal(obj);
                    return number;
                }
            }

            else
            {
                bool noDigitDetected = false;
                foreach (char item in obj.ToString())
                {
                    if (!Char.IsDigit(item))
                    {
                        noDigitDetected = true;
                        break;
                    }
                }
                if (noDigitDetected)
                {
                    return obj;
                }
                else
                {
                    int number = Convert.ToInt32(obj);
                    return number;
                }
            }

        }
    }
}
