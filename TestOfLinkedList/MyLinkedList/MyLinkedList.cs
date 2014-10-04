using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Node<T>
    {
        public T element;
        public Node<T> next = null;
        public Node<T> previous = null;

        public Node()
        {
            this.element = default(T);
        }

        public Node(T _node)
        {
            this.element = _node;
        }

        public void SetNext(T nextvalue)
        {
            this.next = new Node<T>(nextvalue);
        }

        public void SetPrevious(T nextvalue)
        {
            this.previous = new Node<T>(nextvalue);
        }

        public void SetElement(T value)
        {
            this.element = value;
        }

        public T GetElement(T value)
        {
            return this.element;
        }


        internal void SetPrevious(Node<T> tail)
        {
            throw new NotImplementedException();
        }

        internal void SetNext(Node<T> head)
        {
            throw new NotImplementedException();
        }
    }

    public class MyLinkedList<T> : ICollection<T>,IList<T>, ISerializable, IDeserializationCallback
    {
       // LinkedList<T> listOfNodes = new LinkedList<T>();
        
 
        int countOfNodes;
        Node<T> head;
        Node<T> tail;

        public MyLinkedList ()
        {
            head.previous=tail;
            tail.next = head;
        }

        public void AddFirst(T nod)
        {
            Node<T> newnod = new Node<T>(nod);

        }



    }
}
