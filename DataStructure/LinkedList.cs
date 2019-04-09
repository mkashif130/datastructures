using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
    public class LinkedList<T>
    {
        private Node<T> _nodes = new Node<T>();
        private Node<T> _head = null;
        private Node<T> _tail = null;

        public Node<T> Push(T value)
        {
            Node<T> node = new Node<T> { Value = value };
            if (_head == null && _tail == null)
            {
                _head = node;
                _tail = node;
                _nodes = node;
            }
            else
            {
                Node<T> firstNode = _head;
                while (firstNode.Next != null)
                {
                    firstNode = firstNode.Next;

                }
                firstNode.Next = node;
                _tail = node;
            }


            return node;
        }

        public Node<T> Prepend(T value)
        {
            Node<T> node = new Node<T> { Value = value, Next = _head };
            if (_head == null && _tail == null)
            {

                _tail = node;
            }
            _head = node;
            _nodes = node;
            return node;
        }

        public void InsertAfter(Node<T> previousNode, T value)
        {

            Node<T> node = new Node<T> { Value = value, Next = previousNode.Next };
            if (_head ==null && _tail ==null)
            {
                _head = node;
                _tail = node;
                _nodes = node;
            }
            else
            {
                previousNode.Next = node;
                if (node.Next == null)
                {
                    _tail = node;
                }
            }
        }

       
    }
}
