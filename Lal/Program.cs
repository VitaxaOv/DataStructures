﻿using System;
using System.Collections;
using DataStructures;
namespace Lal
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMyList A = new ArrayMyList();
            A.ConsoleArr();

            
            A.Push_Front(55);
            A.Push_Front(99);
            A.Push_Front(99);
            A.Push_Front(13);
            A.Push_Front(11);
            A.ConsoleArr();
            A.Reverse();
            Console.WriteLine();
            A.ConsoleArr();

        }
    }
}
