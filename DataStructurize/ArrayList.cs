using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace DataStructures
{
    public class ArrayList
    {
        private int[] _array;
        public int Lenght { get; private set; }
        public ArrayList()
        {
            _array = new int[3];//сколько у нас всего памяти выделено
            Lenght = 0;//сколько мы хотим элементов положить
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
        public void Push_Front(int value)//добавление значения в начало
        {
            if (Lenght >= _array.Length)
            {
                RizeSizeFront();
            }
            MoveRight(_array.Length);
            _array[0] = value;
            Lenght++;
        }
        private void RizeSizeFront(int size = 1)//увеличение размера когда добавляем вперед
        {
            int newlenght = _array.Length;
            while (newlenght < _array.Length + size)
            {
                newlenght = (int)(newlenght * 1.33d);
            }
            _array = MoveRight(newlenght,size);
        }
        private int[] MoveRight(int newlenght,int index=0,int size=1)// перестановка элементов вправо начиная с элемента index
            //на size элементов массива размером newlenght
        {
            int[] newarray = new int[newlenght];
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
        private void RizeSizeBack(int size=1)//увеличение размера когда добавляем назад
        {
            int newlenght = _array.Length;
            while (newlenght < _array.Length + size)
            {
                newlenght = (int)(newlenght * 1.33d);
            }
            int []newarray = new int[newlenght];
            Array.Copy(_array, newarray, _array.Length);
            _array = newarray;
        }
      
       public void AddElem(int index,int value)// добавление значения по индексу
        {
            if (Lenght >= _array.Length)
            {
                RizeSizeFront();
            }
            MoveRight(_array.Length,index);
            _array[0] = value;
            Lenght++;
        }
    }
}
