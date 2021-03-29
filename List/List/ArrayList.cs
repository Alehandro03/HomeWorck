using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace List
{


    public class ArrayList
    {


        public int Length { get; private set; }

        private int[] _array;
        public int this[int index]
        {
            get
            {
                if (index > Length && index < 0)
                {
                    throw new ArgumentOutOfRangeException("Индекс вне массива");
                }
                return _array[index];
            }

            set
            {
                if (_array[index] != index)
                {
                    throw new ArgumentException("Индекс не входит в длинну массива");

                }
                _array[index] = value;
            }
        }
        public override bool Equals(object obj)
        {
            ArrayList other = (ArrayList)obj;
            if (other.Length != Length)
            {
                return false;
            }
            for (int i = 0; i < Length; i++)
            {
                if (other._array[i] != _array[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            return String.Join(" ", _array.Take(Length));
        }

        public ArrayList()
        {
            Length = 0;
            _array = new int[10];
        }
        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }




        public ArrayList(int[] vs)
        {

            _array = new int[vs.Length];
            _array = vs;
            Length = vs.Length;
            UpSize();

            
        }

        public void Add(int value)
        {
            Length++;

            if (Length == _array.Length)
            {
                UpSize();

            }

            _array[Length-1] = value;
           
        }

        public void AddFirst(int value)
        
        {
            Length++;

            if (Length == _array.Length)
            {
                UpSize();
            }
            
            for (int i = Length-1; i> 0 ; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[0] = value;


        }

        public void AddByIndex(int value, int index)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException();
            }

            Length++;

            if (Length == _array.Length)
            {
                UpSize();
            }
            
            for (int i = Length - 1; i >=index ; i--)
            {

                _array[i] = _array[i-1];

            }

            _array[index] = value;

        }

        public void RemoveLast()
        {          

            Length--;

            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }

        }

        public void RemoveFirst()
        {

            RemoveByIndex(0);

        }

        public void RemoveByIndex(int index)
        {
            
            for (int i = index; i < Length - 1; i++)
            {
                _array[i] = _array[i + 1];

            }
            _array[Length - 1] = 0;

            Length--;
        }
                   
        public void RemoveLastN(int n)
        {
            
            Length -= n;

           

        }

        public void RemoveFirstN(int n)
        
        {
            for (int i = 0; i < Length-n; i++)
            {
                _array[i] = _array[i+n];
            }

            Length-=n;
        }

        public void RemoveByIndexN(int index)
        {
            for (int i = 0; i < Length - index-1; i++)
            {
                _array[i] = _array[0+i];
                Length--;
            }

            Length--;

        }

        public int ArrayLingth()
        {
           return Length;
        }

        public int GetByIndex(int index)
        {
            if(_array[index]!= index)
            {
                throw new ArgumentException("Индекс не входит в длинну массива");

            }
            return _array[index];
        }

        public int GetIndexByValue(int index)       
        {
                      
            return  _array[index];
            
        }
        public void ChengeValueBYIndex(int index, int value)
        {
            _array[index] = value;
        }

        public void Reverse()
        {
            int tmpArrayX = 0;

            for (int i = 0; i < Length / 2; i++)
            {
                tmpArrayX = _array[i];

                _array[i] = _array[Length - 1 - i];  
                
                _array[Length -1 - i ] = tmpArrayX;
            }

        }

       

        public int MaxValue()
        {
            if (Length==0)
            {
                throw new ArgumentException("Длинна массива равно 0");
            }
            int maxValue = _array[0];
           

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] > maxValue)
                {
                    maxValue = _array[i];
                }
            }
            return maxValue;
        }

        public int MinValue()
        {
            if (Length == 0)
            {
                throw new ArgumentException("Длинна массива равно 0");
            }

            int minValue = _array[0];

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] < minValue)
                {
                    minValue = _array[i];
                }
            }
            return minValue;
        }

        public int MaxIndex()
        {
            if (Length == 0)
            {
                throw new ArgumentException("Длинна массива равно 0");
            }
            int indexMax= 0;         

            for (int i = 0; i < Length-1; i++)
            {
                if (_array[i] >_array[indexMax])
                {
                    indexMax = i;
                }
                
            }
            return indexMax;


        }

        public int MinIndex()
        {
            if (Length == 0)
            {
                throw new ArgumentException("Длинна массива равно 0");
            }
            int indexMin = 0;

            for (int i = 0; i < Length - 1; i++)
            {
                if (_array[i] < _array[indexMin])
                {
                    indexMin = i;
                }

            }
            return indexMin;
        }


        public void SortAscending()
        {

            for (int i = 1; i < Length; i++)
            {
                for (int j = 0; j < Length - i; j++)
                {
                    int tmp;

                    if (_array[j + 1] < _array[j])
                    {
                        tmp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = tmp;
                    }
                }
            }
        }

        public void SortDescending()
        {
            for(int i = 1; i < Length; i++)
            {
                for(int j = 0; j < Length; j++)
                {
                    int tmp;
                    if(_array[j+1] > _array[j])
                    {
                        tmp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = tmp;

                    }
                        
                }
            }
        }


        public int RemoveByValueFisrt(int value)
        {
            return RemoveByValue(value);
        }

        public int RemoveByValueAll(int value)
        {
            return RemoveByValue(value, 1);
        }


        private void ShiftToLeft(int index = 0, int step = 1)
        {
            for (int i = index; i < Length - 1; i++)
            {
                _array[i] = _array[i + step];

            }
            _array[Length - 1] = 0;
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
            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }


        private int RemoveByValue(int value, int usl = 0)
        {
            int index = -1;
            int count = 0;

            for (int i = 0; i < Length; i++)
            {
                if (value == _array[i])
                {
                    index = i;
                    ShiftToLeft(i);
                    Length--;
                    i--;
                    count++;

                    if (usl == 0)
                    {
                        break;
                    }
                }
            }

            if (usl == 0)
            {
                return index;
            }
            else
            {
                return count;
            }
        }


    }
}
