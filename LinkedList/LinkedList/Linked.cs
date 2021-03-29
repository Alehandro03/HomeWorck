using System;

namespace LinkedList
{
    public class Linked
    {

        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
                Next = null;
            }

        }
        public int Length { get; private set; }
        public int this[int index]
        {
            get
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }

            set
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }


        public Linked()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public Linked(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }
        public Linked(int[] values)
        {
            

            Length = values.Length;

            if (values.Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }

        public void Add(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }




        private Node _root;
        private Node _tail;
    }
}
