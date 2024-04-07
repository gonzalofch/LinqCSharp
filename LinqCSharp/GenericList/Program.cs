using System;
using System.Collections;

namespace GenericList;

public class Programa
{

    public static void Main(string[] args)
    {
        List<int> genericList1 = new List<int>();
        List<int> genericList2 = new List<int>();

        genericList1.Add(1);
        genericList1.Add(2);
        genericList1.Add(3);
        genericList1.Add(4);
        genericList2.Add(5);
        genericList2.Add(6);
        genericList2.Add(7);
        genericList2.Add(8);
        genericList1.AddRange(genericList2);

        Console.WriteLine("Ex 1");
        //Lista 1 + Lista 2
        foreach (int item in genericList1)
        {
            Console.WriteLine(item);
        }
        //Lista 2 removiendole Sus elementos
        Console.WriteLine("Ex 2");
        foreach (int item in genericList1) {
            Console.WriteLine(item);
        }
        
    }
}