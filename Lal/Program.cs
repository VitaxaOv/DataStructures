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
            A.Push_Back(2);
            A.Push_Back(2);
            A.Push_Back(2);
            A.Push_Back(3);
            Console.WriteLine();
            A.ConsoleArr();
            A.DeleteElem(1);
            A.DeletePerv();
            Console.WriteLine();
            A.ConsoleArr();
        }
    }
}
