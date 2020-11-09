using System;
using System.Collections;
using DataStructures;
namespace Lal
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMyList A = new ArrayMyList();
            

            
            A.Push_Front(55);
            Console.WriteLine();
            A.ConsoleArr();
            A.Push_Front(99);
            A.Push_Back(103);
            Console.WriteLine();
            A.ConsoleArr();
            A.Push_Front(99);
            A.Push_Front(99);
            A.Push_Back(103);
            A.Push_Back(103); A.Push_Back(103); A.Push_Back(103); A.Push_Back(103); A.Push_Back(103); A.Push_Back(103); A.Push_Back(103);
            Console.WriteLine();
            A.ConsoleArr();
            A.Push_Front(13);
            Console.WriteLine();
            A.ConsoleArr();
            A.Push_Front(11);
            Console.WriteLine();
            A.ConsoleArr();
           
            A.Reverse();
            Console.WriteLine();
            A.ConsoleArr();
            A.ArraySort();
            Console.WriteLine();
            A.ConsoleArr();
            
            Console.WriteLine();
            int[] arr = new int[] { 1, 2,3,4,5,6,7,8,9};
            A.Push_FrontArray(arr);
            A.ConsoleArr();
        }
    }
}
