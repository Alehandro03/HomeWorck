using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ArrayList
    {
        

        public int Length { get; private set; }

        private int[] _array;
        
         
        public ArrayList()
        {
            Length = 0;

            _array = new int[10];
        }
        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }            
            _array[Length] = value;
            Length++;
        }

        public void AddFirst(int value)
            //???
        {
            if(Length == _array.Length)
            {
               UpSize();
            }
            int[] tmpArray = new int[_array.Length];
            tmpArray[0] = value;
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i + 1] = _array[i];
            }
            _array = tmpArray;
            Length++;
        }

        public void AddIndex(int value,int index)
        {
            if(Length == _array.Length)
            {
                UpSize();
            }
            int[] tmpArray = new int[_array.Length];
            tmpArray[index] = value; 
            for(int i = 0;i<_array.Length;i++)
            {
                tmpArray[i + 1] = _array[i];
            }
            _array = tmpArray;
            Length++;

        }

        public void RemoveLast()
        {
            Length--;
            if(Length<=(_array.Length/2))
            {
                DownSize();
            }
        }

        public void RemoveFirst()
        {//???
            
            for(int i =Length;i>0;i--)
            {
                _array[i] = _array[i-1];
            }
            
            Length--;
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        public void RemoveByIndex(int index, int value)
        {
            int[] tmpArray = new int[_array.Length];
            for(int i = 0; i <index;i++)
            {
                tmpArray[i] = _array[i];
            }
            for(int i = index-1; i <_array.Length-1 ; i++ )
            {
                tmpArray[i] = _array[i+1];
            }
            _array = tmpArray;
            Length--;

        }

        public void RemoveLastN(int n)
        {
            int[] tmpArray = new int[_array.Length];
            
            for(int i = 0; i < _array.Length - n;i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
            Length -= n;
            if(Length<= (_array.Length / 2))
            {
                DownSize();
            }

        }

        public void RemoveFirstN(int n)
            //???
        {
            int[] tmpArray = new int[_array.Length];
            for(int i = _array.Length;i>0;i++)
            {
                tmpArray[i - n] = _array[i];
            }
            _array = tmpArray;
            Length -= n;
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }


        }

        public void RemoveByIndexN(int index, int value, int n)
            //???
        {
            int[] tmpArray = new int[_array.Length];
            for(int i =0; i < index; i++)
            {
                tmpArray[i] = _array[i];
            }
            for(int i = index - 1; i < _array.Length - n; i++)
            {
                tmpArray[i] = _array[i + n];
            }
            _array = tmpArray;
            Length -= n;

        }

        public int GetByIndex(int index)
        {
            return _array[index];
        }

        public int GetIndexByValue(int value)
            //???
        {
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i ;
                    break;
                }
            }
            return index;
        }
        public void ChengeValueBYIndex(int index, int value)
        {
            _array[index - 1] = value;
        }

        public void Reverse(int tmpArrayX)
        {
           
            for (int i = 0;  i < (Length / 2);i++)
            {
                tmpArrayX = _array[i];
                int x = Length - i - 1;
                _array[i] = _array[x];
                _array[x] = tmpArrayX;
            }

        }



        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.33d + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }

            _array = tmpArray;

        }

        private void DownSize()
        {
            int newLength = (int)(_array.Length * 0.67d + 1);
            int[] tmpArray = new int[newLength];
            for(int i = 0; i<tmpArray.Length;i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        


    }
}
