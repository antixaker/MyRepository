using System;
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
        public Node<T> Next = null;
        public Node<T> Prev = null;

        public Node()
        {
            this.Value = default(T);
            this.Next = null;
            this.Prev = null;
        }

        public Node(T _node)
        {
            this.Value = _node;
        }
    }

    public class OwnLinkedList<T> : IEnumerable<T>
    {

        #region Property

        Node<T> _first;
        Node<T> _last;
        Node<T> curr;

        int size;

        public Node<T> First
        {
            get { return _first; }
        }

        public Node<T> Last
        {
            get { return _last; }
        }

        public int Count
        {
            get { return size; }
        }

        #endregion

        #region Methods

        public OwnLinkedList()
        {
            _first = _last = curr = null;
            size = 0;
        }

        public void AddFirst(T nod)
        {
            Node<T> newnod = new Node<T>(nod);
            if (_first == null)
            {
                _first = _last = newnod;
            }
            else
            {
                newnod.Next = _first;
                _first = newnod;
                newnod.Next.Prev = _first;
            }
            size++;
        }

        public void AddLast(T nod)
        {
            Node<T> newnod = new Node<T>(nod);
            if (_last == null)
            {
                _last = _first = newnod;
            }
            else
            {
                newnod.Prev = _last;
                _last.Next = newnod;
                _last = newnod;
            }
            size++;
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
            _first = _last = curr = null;
            size = 0;
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
                    size--;
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        public bool RemoveFirst()
        {
            if (_first != null)
            {
                _first.Next.Prev = null;
                _first = _first.Next;
                size--;
                return true;

            }
            else return false;
        }

        public bool RemoveLast()
        {
            if (_last != null)
            {
                _last.Prev.Next = null;
                _last = _last.Prev;
                size--;
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

        #endregion

        public class OwnLinkedList_numerator : IEnumerator<Node<T>>
        {


            //public object Current
            //{
            //    get { throw new NotImplementedException(); }
            //}

            //public bool MoveNext()
            //{
            //    throw new NotImplementedException();
            //}

            //public void Reset()
            //{
            //    throw new NotImplementedException();
            //}
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
                if (exemp._first.Next != null)
                {
                    current = exemp._first = exemp._first.Next;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                current = exemp.First;
            }
        }
    }
}
