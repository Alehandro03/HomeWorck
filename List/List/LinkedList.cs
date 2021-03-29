using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace List
{
    public class LinkedList
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

        public override string ToString()
        {
            if (Length != 0)
            {
                Node current = _root;
                string s = current.Value + " ";

                while (!(current.Next is null))
                {
                    current = current.Next;
                    s += current.Value + " ";
                }

                return s;
            }
            else
            {
                return String.Empty;
            }
        }
        public override bool Equals(object obj)
        {
            LinkedList list = (LinkedList)obj;

            if (this.Length != list.Length)
            {
                return false;
            }

            Node currentThis = this._root;
            Node currentList = list._root;

            do
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
                currentList = currentList.Next;
                currentThis = currentThis.Next;
            }
            while (!(currentThis.Next is null));

            return true;
        }

        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }
        

        public LinkedList(int[] values)
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

        public void AddFirst(int value)
        {
            Node tmpNode = _root;
            _root = new Node(value);
            _root.Next = tmpNode;
            Length++;
        }

        public void AddByIndex( int value, int index)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (Length != 0 && Length != 1)
            {
                Length++;
                Node current = GetNodeByIndex(index - 1);

                Node tmp = new Node(value);
                tmp.Next = current.Next;
                current.Next = tmp;
            }
            else
            {

            }
            {
                if (Length == 0)
                {
                    AddValueToEmptyList(value);
                }
                else
                {
                    
                }
            }


        }

        public void RemoveLast()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (Length != 1)
            {
                Node current = _root;
                for (int i = 1; i < Length - 1; i++)
                {
                    current = current.Next;
                }
                //Node current = GetNodeByIndex(Length - 1);
                current.Next = null;
                _tail = current;
                Length--;
            }
            else
            {
                Length = 0;
                _root = null;
                _tail = null;
            }
        }

        public void RemoveFirst()
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (Length != 1)
            {
                _root = _root.Next;
                Length--;
            }
            else
            {
                Length = 0;
                _root = null;
                _tail = null;
            }
        }

        public void RemoveByIndex(int index)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length != 1)
            {
                Node current = GetNodeByIndex(index - 1);
                current.Next = current.Next.Next;
                Length--;
            }
            else
            {
                Length = 0;
                _root = null;
                _tail = null;
            }
        }

        public void RemoveLastN(int n)
        {
            if (Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (n > Length)
            {
                throw new ArgumentException();
            }
            if (Length != 1)
            {
                Node current = GetNodeByIndex(Length - n - 1);
                current.Next = null;
                _tail = current;
                Length -= n;
            }
            else
            {
                Length = 0;
                _root = null;
                _tail = null;
            }
        }


        private Node _root;
        private Node _tail;
        private Node GetNodeByIndex(int index)
        {
            Node current = _root;
            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }
            return current;
        }

        private Node AddValueToEmptyList(int values)
        {
            Length = 1;
            _root = new Node(values);
            _tail = _root;
            return _root;
        }

        public void AddValueToTheBegin(LinkedList linkedList)
        {
            Length = Length + linkedList.Length;
            linkedList._tail.Next = _root;
            _root = linkedList._root;
        }



    }
}
