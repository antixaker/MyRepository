﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node<T> Prev;

        public Node()
        {
            this.Value = default(T);
        }

        public Node(T _node)
        {
            this.Value = _node;
        }
    }

    public class OwnLinkedList<T> : IEnumerable<T>
    {

        #region Property

        Node<T> first;
        Node<T> last;
        Node<T> curr;

        int count;

        public Node<T> First
        {
            get { return first; }
        }

        public Node<T> Last
        {
            get { return last; }
        }

        public int Count
        {
            get { return count; }
        }

        #endregion

        #region Methods

        public void AddFirst(T nod)
        {
            Node<T> newnod = new Node<T>(nod);
            if (first == null)
            {
                first = last = newnod;
            }
            else
            {
                newnod.Next = first;
                first = newnod;
                newnod.Next.Prev = first;
            }
            count++;
        }

        public void AddLast(T nod)
        {
            Node<T> newnod = new Node<T>(nod);
            if (last == null)
            {
                last = first = newnod;
            }
            else
            {
                newnod.Prev = last;
                last.Next = newnod;
                last = newnod;
            }
            count++;
        }

        public Node<T> Find(T value)
        {
            curr = First;
            while (curr != null)
            {
                if (curr.Value.Equals(value))
                {
                    return curr;
                }
                curr = curr.Next;
            }
            return null;
        }

        public void Clear()
        {
            first = last = curr = null;
            count = 0;
        }

        public bool Remove(T value)
        {
            curr = First;
            while (curr != null)
            {
                if (curr.Value.Equals(value))
                {
                    curr.Next.Prev = curr.Prev;
                    curr.Prev.Next = curr.Next;
                    count--;
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        public bool RemoveFirst()
        {
            if (first != null)
            {
                first.Next.Prev = null;
                first = first.Next;
                count--;
                return true;

            }
            else return false;
        }

        public bool RemoveLast()
        {
            if (last != null)
            {
                last.Prev.Next = null;
                last = last.Prev;
                count--;
                return true;

            }
            else return false;
        }

        #endregion

        #region Enumerator

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)(new OwnLinkedList_numerator(this));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class OwnLinkedList_numerator : IEnumerator<Node<T>>
        {


            OwnLinkedList<T> exemp;
            Node<T> current;
            public OwnLinkedList_numerator(OwnLinkedList<T> got)
            {
                exemp = got;
            }

            public Node<T> Current
            {
                get { return current; }
            }

            public void Dispose()
            {

            }

            object IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            public bool MoveNext()
            {
                if (exemp.first.Next != null)
                {
                    current = exemp.first = exemp.first.Next;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                current = exemp.First;
            }
        }


        #endregion

    }
}
