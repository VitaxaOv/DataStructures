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
            _array = new int[3];//сколько у нас всего памяти выделено
            Lenght = 0;//сколько мы хотим элементов положить
        }
        public void ConsoleArr()
        {
            for(int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
        public void Push_Back(int value)//добавление значения в конец
        {
            if (Lenght >= _array.Length)
            {
                RizeSizeBack();
            }            
            
            _array[Lenght] = value;
            Lenght++;
        }
        private void RizeSizeBack(int size = 1)//увеличение размера когда добавляем назад
        {
            int newlenght = _array.Length;
            while (newlenght <= _array.Length + size)
            {
                newlenght = (int)(newlenght * 1.5d);
            }
           
            int[] newarray = new int[newlenght];
            Array.Copy(_array, newarray, _array.Length);
            _array = newarray;
        }
        public void Push_Front(int value)//добавление значения в начало
        {
            if (Lenght >= _array.Length)
            {
                RizeSizeFront();
            }
            _array = MoveRight(_array.Length);
            _array[0] = value;
            Lenght++;
        }
        private void RizeSizeFront(int size = 1)//увеличение размера когда добавляем вперед
        {
            int newlenght = _array.Length;
            while (newlenght <= _array.Length + size)
            {
                newlenght = (int)(newlenght * 1.5d);
            }
           _array=MoveRight(newlenght);
        }
        private int[] MoveRight(int newlenght, int index = 0, int size = 1)// перестановка элементов вправо начиная с элемента index
                                                                           //на size элементов массива размером newlenght
        {
            int[] newarray = new int[newlenght+size];
            for (int i = index; i < Lenght; i++)
            {
                newarray[i + size] = _array[i];
            }
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    newarray[i] = _array[i];
                }
            }

            return newarray;
        }


        public void AddElem(int index, int value)// добавление значения по индексу
        {
            if (Lenght >= _array.Length)
            {
                RizeSizeFront();
            }
           _array= MoveRight(_array.Length, index);
            _array[index] = value;
            Lenght++;
        }
        // удаление из конца одного элемента
        public void PopBack(int size = 1)
        {
            int[] newarray = new int[Lenght - size];
            Array.Copy(_array, newarray, Lenght - size);
            _array = newarray;
            RizeSizeBack();
        }
        //удаление из начала одного элемента
        public void PopFront(int size = 1)
        {
            _array = MoveLeft(_array.Length);
        }
        private int[] MoveLeft(int newlenght, int index = 0, int size = 1)
        {
            int[] newarray = new int[newlenght + size];
            for (int i = index; i < Lenght; i++)
            {
                newarray[i] = _array[i+size];
            }
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    newarray[i] = _array[i];
                }
            }

            return newarray;

        }
        public void DeleteElem(int index)// удаление значения по индексу
        {
            _array = MoveLeft(_array.Length,index);
        }
        //доступ по индексу
        public int Index(int index)// удаление значения по индексу
        {
            return _array[index];
        }
        public int FindIndex(int value)// поиск индекса по значению
        {
            for(int i = 0; i < Lenght; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
           
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
    }
}
