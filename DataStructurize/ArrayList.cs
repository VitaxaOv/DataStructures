using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace DataStructures
{
    public class ArrayMyList
    {
        private int[] _array;
        public int Lenght { get; private set; }
        public ArrayMyList()
        {
            _array = new int[3];
            Lenght = 0;
        }
        public ArrayMyList(int[] array)
        {
            if (array.Length == 0)
            {
                _array = new int[3];
                Lenght = 0;

            }
            else
            {
                _array = new int[(int)(array.Length * 1.34d)];
                Array.Copy(array, _array, (int)(array.Length));
                Lenght = array.Length;
            }
        }
        public ArrayMyList(int value)
        {
            _array = new int[(int)(value * 1.34d)];
            Lenght = 1;
        }
        public void Push_Back(int value)
        {
            if (Lenght >= _array.Length)
            {
                RizeSizeBack();
            }

            _array[Lenght] = value;
            Lenght++;
        }
        public int GetLenght()
        {
            return Lenght;
        }
        public void Push_BackArray(int[] arr)
        {
            if (Lenght + arr.Length > _array.Length)
            {
                RizeSizeBack(arr.Length);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                _array[Lenght + i] = arr[i];
            }

            Lenght += arr.Length;
        }
        public void Reverse()
        {
            for (int i = 0; i < Lenght / 2; i++)
            {
                int tmp = _array[i];
                _array[i] = _array[Lenght - 1 - i];
                _array[Lenght - 1 - i] = tmp;
            }
        }

        public void Push_Front(int value)
        {
            if (Lenght >= _array.Length)
            {
                RizeSizeBack();
            }
            MoveRight(_array.Length);
            _array[0] = value;
            Lenght++;
        }
        public void Push_FrontArray(int[] arr)
        {
            if (Lenght + arr.Length > _array.Length)
            {
                RizeSizeBack(arr.Length);
            }
            MoveRight(_array.Length, 0, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                _array[i] = arr[i];
            }

            Lenght += arr.Length;
        }
        
        


        public void AddElem(int index, int value)
        {
            if (index > Lenght || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (Lenght >= _array.Length)
            {
                RizeSizeBack();
            }
            MoveRight(_array.Length, index);
            _array[index] = value;
            Lenght++;
        }
        public void AddArr(int index, int[] arr)
        {
            if (index > Lenght || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (Lenght + arr.Length >= _array.Length)
            {
                RizeSizeBack(arr.Length);
            }
             MoveRight(_array.Length, index, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                _array[i + index] = arr[i];
            }
            Lenght += arr.Length;
        }


        
        public void PopBack(int size = 1)
        {
            if (size > Lenght)
            {
                throw new IndexOutOfRangeException();
            }
            
            Lenght -= size;
        }

       
        public void PopFront(int size = 1)
        {
            if (size > Lenght)
            {
                throw new IndexOutOfRangeException();
            }
            MoveLeft(_array.Length,0,size);
            Lenght -= size;
        }
       
       

        public void DeleteElem(int index, int number=1)
        {
            if (index > Lenght - 1 || index < 0|| number > Lenght)
            {
                throw new IndexOutOfRangeException();
            }
            
            MoveLeft(_array.Length, index, number);
            Lenght -= number;
        }
        public int this[int index]
        {
            get
            {
                if (index > Lenght - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index > Lenght - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public int FindIndex(int value)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;

        }
        public int[] ArraySort()
        {
            for (int i = 0; i < Lenght; i++)
            {
                for (int j = 1; j < Lenght; j++)
                {
                    if (j > i)
                    {
                        if (_array[i] > _array[j])
                        {
                            int tmp;
                            tmp = _array[i];
                            _array[i] = _array[j];
                            _array[j] = tmp;
                        }
                    }
                }
            }
            return _array;
        }
        public int[] ArraySortReverse()
        {
            for (int i = 0; i < Lenght; i++)
            {
                for (int j = 1; j < Lenght; j++)
                {
                    if (j > i)
                    {
                        if (_array[i] < _array[j])
                        {
                            int tmp;
                            tmp = _array[i];
                            _array[i] = _array[j];
                            _array[j] = tmp;
                        }
                    }
                }
            }
            return _array;
        }
        public double FindMin()
        {
            if (Lenght == 0)
            {
                throw new Exception("Массив пустой");
            }

            return _array[FindMinIndex()];
        }

        public double FindMax()
        {
            if (Lenght == 0)
            {
                throw new Exception("Массив пустой");
            }
            return _array[FindMaxIndex()];
        }
        public int FindMinIndex()
        {
            if (Lenght == 0)
            {
                throw new Exception("Массив пустой");
            }
            int index = 0;
            int max = 999999;
            for (int i = 0; i < Lenght; i++)
            {
                if (max > _array[i])
                {
                    max = _array[i];
                    index = i;
                }
            }

            return index;
        }
        public int FindMaxIndex()
        {
            if (Lenght == 0)
            {
                throw new Exception("Массив пустой");
            }
            int index = 0;
            int max = -999999;
            for (int i = 0; i < Lenght; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                    index = i;
                }
            }
            return index;
        }
        public void DeletePerv()
        {
            
            
                for (int j = 1; j < Lenght; j++)
                {
                    if (_array[0] == _array[j])
                    {
                        DeleteElem(j);
                    j -= 1;
                        
                    }
                }
        }
        public void DeleteEqual()
        {

            for (int i = 0; i < Lenght-1; i++)
            {
                for (int j = i; j < Lenght-1; j++)
                {
                    if (_array[j] == _array[j+1])
                    {
                        DeleteElem(j);
                        j -= 1;

                    }
                }
            }

        }
        public override bool Equals(object obj)
        {
            ArrayMyList arrayList = (ArrayMyList)obj;

            if (Lenght != arrayList.Lenght)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (_array[i] != arrayList._array[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void MoveLeft(int newlenght, int index = 0, int size = 1)
        {
            if (size > Lenght - index)
            {
                throw new Exception();
            }
            if (Lenght == 1)
            {
                int[] newarray = new int[] { };
                _array = newarray;
            }
            else
            {
                for (int i = index; i < Lenght - 1; i++)
                {
                    _array[i] = _array[i + size];
                }
            }

        }
      
        private void RizeSizeBack(int size = 1)
        {
            int newlenght = _array.Length;
            while (newlenght < Lenght + size)
            {
                newlenght = (int)(newlenght * 1.34d);
            }

            int[] newarray = new int[newlenght];
            Array.Copy(_array, newarray, _array.Length);
            _array = newarray;
        }
        private void MoveRight(int newlenght, int index = 0, int size = 1)
        {
            for (int i = Lenght - 1; i >= index; i--)
            {
                _array[i + size] = _array[i];

            }

        }
    }
}
